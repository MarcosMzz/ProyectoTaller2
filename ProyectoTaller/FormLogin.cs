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
                    string query = "SELECT u.ID_Usuario, u.Nombre, u.Apellido, u.Email, p.Descripcion FROM Usuarios u INNER JOIN Perfiles p ON u.ID_Perfiles = p.ID_Perfiles WHERE u.Email = @Email AND u.Pass = @Pass;";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Pass", pass);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // si encontró un usuario
                            {
                                Sesion.UsuarioId = reader.GetInt32(0);   // columna 1 → ID_Usuario
                                Sesion.Nombre = reader.GetString(1); // columna 2 → Nombre
                                Sesion.Apellido = reader.GetString(2); // columna 3 → Apellido
                                Sesion.Email = reader.GetString(3); // columna 4 → Email
                                Sesion.Rol = reader.GetString(4);  // columna 5 → ID_Perfiles
                                Sesion.LoginExitoso = true;
                                MessageBox.Show("Inicio de sesion exitoso");

                                FormPrincipal formPrincipal = new FormPrincipal();
                                this.Hide(); // oculta el login
                                formPrincipal.ShowDialog(); // abre el menú principal
                                this.Close(); // cierra el login cuando cierres el principal
                            }
                            else
                            {
                                MessageBox.Show("Credenciales inválidas");
                            }
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
