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
    public partial class FormAgregarClientes : Form
    {

        private DataGridViewRow filaOriginal;
        public FormAgregarClientes(DataGridViewRow fila = null)
        {
            InitializeComponent();

            filaOriginal = fila;

            if (filaOriginal != null)
            {
                // Rellenamos los TextBox con los datos existentes
                TBNombre.Text = filaOriginal.Cells["NombreColumna"].Value.ToString();
                TBApellido.Text = filaOriginal.Cells["ApellidoColumna"].Value.ToString();
                TBDni.Text = filaOriginal.Cells["DniColumna"].Value.ToString();
                TBNroTelefono.Text = filaOriginal.Cells["TelefonoColumna"].Value.ToString();
                TBEmail.Text = filaOriginal.Cells["EmailColumna"].Value.ToString();
                TBDireccion.Text = filaOriginal.Cells["DireccionColumna"].Value.ToString();
                DTCliente.Value = DateTime.Parse(filaOriginal.Cells["FechaDeNacimientoColumna"].Value.ToString());
            }
        }

        private FormPrincipalClientes formPrincipal; // referencia al form principal


        public FormAgregarClientes(FormPrincipalClientes form)
        {
            InitializeComponent();
            formPrincipal = form; // guardamos la referencia
        }

        private void limpiarCampos(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = "";
            }
        }

        private void agregarCliente(object sender, EventArgs e)
        {
            if (CamposVacios(TBNombre, TBApellido, TBNroTelefono, TBDni, TBEmail, TBDireccion))
            {
                MessageBox.Show("Rellena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (filaOriginal != null)
            {
                filaOriginal.Cells["NombreColumna"].Value = TBNombre.Text;
                filaOriginal.Cells["ApellidoColumna"].Value = TBApellido.Text;
                filaOriginal.Cells["DNIColumna"].Value = TBDni.Text;
                filaOriginal.Cells["TelefonoColumna"].Value = TBNroTelefono.Text;
                filaOriginal.Cells["EmailColumna"].Value = TBEmail.Text;
                filaOriginal.Cells["DireccionColumna"].Value = TBDireccion.Text;
                filaOriginal.Cells["FechaDeNacimientoColumna"].Value = DTCliente.Value.ToShortDateString();
            }
            else
            {
                string nombre = TBNombre.Text;
                string apellido = TBApellido.Text;
                string nroDeTelefono = TBNroTelefono.Text;
                int dni = int.Parse(TBDni.Text);
                string email = TBEmail.Text;
                string direccion = TBDireccion.Text;
                DateTime fechaDeNacimiento = DateTime.Now;

                
            }
            

            this.Close();

        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool CamposVacios(params TextBox[] textBoxes)
        {
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    return true; 
                }
            }
            return false; 
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
