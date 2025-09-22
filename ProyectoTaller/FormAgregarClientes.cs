using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public FormAgregarClientes()
        {
            InitializeComponent();

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

            string Nombre = TBNombre.Text;
            string Apellido = TBApellido.Text;
            string nroDeTelefono = TBNroTelefono.Text;
            int DNI = int.Parse(TBDni.Text);
            string Email = TBEmail.Text;
            string Direccion = TBDireccion.Text;
            DateTime FechaDeNacimiento = DTCliente.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"INSERT INTO Cliente(Nombre, Apellido, Email, Telefono, Direccion, FechaNacimiento, DNI) 
                                    VALUES (@Nombre, @Apellido, @Email, @nroDeTelefono, @Direccion, @FechaDeNacimiento, @DNI)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@FechaDeNacimiento", FechaDeNacimiento);
                        cmd.Parameters.AddWithValue("@DNI", DNI);
                        cmd.Parameters.AddWithValue("@Direccion", Direccion);
                        cmd.Parameters.AddWithValue("@nroDeTelefono", nroDeTelefono);

                        cmd.ExecuteNonQuery();

                        formPrincipal.CargarClientes();
                    }
                }

                MessageBox.Show("Clientes agregado correctamente.");
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // violación de PK o UNIQUE
                {
                    if (ex.Message.Contains("PK_Cliente"))
                        MessageBox.Show("Ya existe un cliente con ese identificador (PK).");
                    else if (ex.Message.Contains("UQ_DNI"))
                        MessageBox.Show("Ya existe un cliente registrado con ese DNI.");
                    else if (ex.Message.Contains("UQ_Email_Cliente"))
                        MessageBox.Show("Ya existe un cliente registrado con ese Email.");
                    else
                        MessageBox.Show("Error: ya existe un cliente con datos duplicados.");
                }
                else
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }


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
