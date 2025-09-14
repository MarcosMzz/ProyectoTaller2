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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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

        private void Loggearse(object sender, EventArgs e)
        {
            string email = TBCorreo.Text.Trim();
            string pass = TBPass.Text.Trim();

            if (CamposVacios(TBCorreo, TBPass))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Connection string usando localhost
                string conexion = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    // Consulta SQL segura con parámetros
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Pass = @Pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Pass", pass);

                        int resultado = (int)cmd.ExecuteScalar();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Login exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Abrir FormPrincipal o siguiente paso
                        }
                        else
                        {
                            MessageBox.Show("Email o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
