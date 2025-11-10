using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            refrescarForm();

            
        }

        private void refrescarForm()
        {
            ActualizarInfoUsuarioLabels();

            this.Text = $"Bienvenido {Sesion.Nombre} {Sesion.Apellido} - Rol: {Sesion.Rol}";

            MSBackup.Visible = false;


            if (Sesion.Rol == "Administrador")
            {
                MSClientes.Enabled = true;
                MSVehiculos.Enabled = false;
                MSVentas.Enabled = false;
                MSUsuarios.Enabled = true;
                MSBackup.Visible = true;
            }
            else if (Sesion.Rol == "Vendedor")
            {
                MSClientes.Enabled = true;
                MSVehiculos.Enabled = false;
                MSVentas.Enabled = true;
                MSUsuarios.Enabled = false;

            }
            else if (Sesion.Rol == "Supervisor")
            {
                MSClientes.Enabled = true;
                MSVehiculos.Enabled = true;
                MSVentas.Enabled = true;
                MSUsuarios.Enabled = false;
            }
            else
            {
                MSClientes.Enabled = false;
                MSVehiculos.Enabled = false;
                MSVentas.Enabled = false;
                MSUsuarios.Enabled = false;
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new FormPrincipalClientes());
            
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new FormPrincipalAutos());
        }

        public void abrirForm(Form childForm)
        {
            // Cierra todos los formularios hijos abiertos
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // Configura el formulario hijo
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void abrirVentas(object sender, EventArgs e)
        {
            if (Sesion.Rol == "Vendedor")
            {
                abrirForm(new FormAgregarVentas());
            }
            else if (Sesion.Rol == "Supervisor")
            {
                abrirForm(new FormPrincipalVentasSupervisor());
            }
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            // === Cierra cualquier formulario MDI hijo ===
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // Limpiar la sesión
            Sesion.UsuarioId = 0;
            Sesion.Nombre = null;
            Sesion.Apellido = null;
            Sesion.Email = null;
            Sesion.Rol = null;
            Sesion.LoginExitoso = false;

            // === Ocultar y Abrir Login ===
            this.Hide();

            // Usamos 'using' para garantizar que la ventana de login se destruya al salir.
            using (FormLogin login = new FormLogin())
            {
                login.ShowDialog();
            }

            // === Decisión Final (Control de Duplicación) ===
            if (Sesion.LoginExitoso)
            {
                // Solo volvemos a mostrar la misma instancia de FormPrincipal.
                this.Show();
                refrescarForm();
            }
            else
            {
                // Si el usuario cerró el login, cerramos esta instancia del Principal
                // para terminar la aplicación.
                this.Close();
            }
        }

        private void abrirUsuarios(object sender, EventArgs e)
        {
            abrirForm(new FormPrincipalUsuarios());
        }

        private void abrirFormBackUp(object sender, EventArgs e)
        {
            abrirForm(new FormBackUpDB());
        }

        private void ActualizarInfoUsuarioLabels()
        {
            // Verificamos si hay una sesión activa para mostrar los datos
            if (Sesion.LoginExitoso)
            {
                // Concatenamos Nombre y Apellido
                LBNombre.Text = Sesion.Nombre;
                LBApellido.Text = Sesion.Apellido;

                // Asignamos el Rol
                LBRol.Text = Sesion.Rol;
            }
            else
            {
                // Caso de emergencia, si no hay sesión
                LBNombre.Text = "Invitado";
                LBRol.Text = "Sin Rol";
            }
        }
    }
}
