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
    public partial class FormModifClientes : Form
    {
        private int id_editar;

        private FormPrincipalClientes formPrincipal; // referencia al form principal

        public FormModifClientes(FormPrincipalClientes form, int id)
        {
            InitializeComponent();
            formPrincipal = form;
            this.id_editar = id;
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
            if (CamposVacios(TBNombre, TBApellido, TBNroTelefono, TBEmail, TBDireccion))
            {
                MessageBox.Show("Rellena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Nombre = TBNombre.Text;
            string Apellido = TBApellido.Text;
            string Telefono = TBNroTelefono.Text;
            string Email = TBEmail.Text;
            string Direccion = TBDireccion.Text;


            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Cliente 
                                      SET Nombre = @Nombre, 
                                          Apellido = @Apellido,     
                                          Email = @Email,   
                                          Telefono = @Telefono, 
                                          Direccion = @Direccion    
                                      WHERE ID_Cliente = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Direccion", Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", Telefono);
                        cmd.Parameters.AddWithValue("@Id", this.id_editar);

                        cmd.ExecuteNonQuery();

                        formPrincipal.CargarClientes();
                    }
                }

                MessageBox.Show("Cliente modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.Message);
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

        private void FormModifClientes_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                conn.Open();

                string query = "SELECT Nombre, Apellido, Email, Telefono, Direccion FROM Cliente WHERE ID_Cliente = @Id";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", this.id_editar);
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TBNombre.Text = reader["Nombre"].ToString();
                        TBApellido.Text = reader["Apellido"].ToString();
                        TBEmail.Text = reader["Email"].ToString();
                        TBNroTelefono.Text = reader["Telefono"].ToString();
                        TBDireccion.Text = reader["Direccion"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.");
                        this.Close();
                    }
                }
            }
        }
    }
}
