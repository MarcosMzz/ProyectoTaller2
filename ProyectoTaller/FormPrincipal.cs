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
            this.Text = $"Bienvenido {Sesion.Nombre} {Sesion.Apellido} - Rol: {Sesion.Rol}";

            if (Sesion.Rol == "Administrador")
            {
                MSClientes.Enabled = true;
                MSVehiculos.Enabled = false;
                MSVentas.Enabled = false;
                MSUsuarios.Enabled = true;
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
            // Limpiar la sesión
            Sesion.UsuarioId = 0;
            Sesion.Nombre = null;
            Sesion.Apellido = null;
            Sesion.Email = null;
            Sesion.Rol = null;
            Sesion.LoginExitoso = false;

            // Ocultar el formulario principal
            this.Hide();

            // Abrir login
            FormLogin login = new FormLogin();
            login.ShowDialog();

            // Revisar si login fue exitoso
            if (Sesion.LoginExitoso)
            {
                this.Show(); // volver a mostrar principal
            }
            else
            {
                // Si se cerró con X o canceló, cerramos la app
                this.Close();
            }
        }

        private void abrirUsuarios(object sender, EventArgs e)
        {
            abrirForm(new FormPrincipalUsuarios());
        }
    }
}
