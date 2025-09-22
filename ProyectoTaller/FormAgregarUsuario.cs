using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoTaller
{
    public partial class FormAgregarUsuario : Form
    {
        private FormPrincipalUsuarios formPadre; // referencia al form principal
        public FormAgregarUsuario(FormPrincipalUsuarios padre)
        {
            InitializeComponent();
            this.Load += cargarTiposDePerfiles;
            formPadre = padre;
        }

        private void cargarTiposDePerfiles(object sender, EventArgs e)
        {
            CargarTiposUsuario();
        }

        private void CargarTiposUsuario()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Perfiles, Descripcion FROM Perfiles", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                CBTipoUsuario.DataSource = dt;
                CBTipoUsuario.DisplayMember = "Descripcion";   // Lo que se ve en el combo
                CBTipoUsuario.ValueMember = "ID_Perfiles";     // El valor interno (clave primaria)
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CamposVacios(TBNombre, TBApellido,TBEmail, TBPass))
            {
                MessageBox.Show("Rellena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Nombre = TBNombre.Text;
            string Apellido = TBApellido.Text;
            string Email = TBEmail.Text;
            string pass = TBPass.Text;
            DateTime FechaDeNacimiento = DTFechaNacimiento.Value;
            int idPerfil = Convert.ToInt32(CBTipoUsuario.SelectedValue); // ID_Perfiles

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"INSERT INTO Usuarios(Nombre, Apellido, Email, pass, ID_Perfiles, FechaNacimiento) 
                                    VALUES (@Nombre, @Apellido, @Email, @pass, @ID_Perfiles ,@FechaDeNacimiento)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", Apellido);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@FechaDeNacimiento", FechaDeNacimiento);
                        cmd.Parameters.AddWithValue("@ID_Perfiles", idPerfil);

                        cmd.ExecuteNonQuery();

                        //formPrincipal.CargarClientes(); // refresca la grilla automáticamente
                        
                    }
                }

                
                MessageBox.Show("Usuario agregado correctamente.");
                formPadre.CargarUsuarios();
                this.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // violación de PK o UNIQUE
                {
                    if (ex.Message.Contains("PK_Usuarios"))
                        MessageBox.Show("Ya existe un Usuario con ese identificador (PK).");
                    else if (ex.Message.Contains("UQ_Email"))
                        MessageBox.Show("Ya existe un Usuario registrado con ese Email.");
                    else
                        MessageBox.Show("Error: ya existe un Usuario con datos duplicados.");
                }
                else
                {
                    MessageBox.Show("Error al agregar Usuario: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

        }

        private void cerrarForn(object sender, EventArgs e)
        {
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

    }

}
