using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                MSVehiculos.Enabled = true;
            }
            else if (Sesion.Rol == "Vendedor")
            {
                MSClientes.Enabled = true;
                MSVehiculos.Enabled = false;
            }
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new FormPrincipalClientes());
            
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Form1());
        }
        private void abrirForm(Form childForm)
        {
            // Cierra todos los formularios hijos abiertos
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            // Configura el formulario hijo
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.Manual;

            // Calcula la posición para centrar el formulario
            int x = (this.ClientSize.Width - childForm.Width) / 2;
            int y = (this.ClientSize.Height - childForm.Height) / 2;
            childForm.Location = new Point(Math.Max(x, 0), Math.Max(y, 0));

            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
    }
}
