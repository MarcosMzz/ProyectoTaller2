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
    public partial class FormModificarUsuario : Form
    {
        private int id_editar;

        private FormPrincipalUsuarios formPrincipal; // referencia al form principal
        public FormModificarUsuario(FormPrincipalUsuarios form, int id)
        {
            InitializeComponent();
            formPrincipal = form;
            this.id_editar = id;
        }

        private void cerrarFormModificarUsuario(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTiposUsuario()
        {
            using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Perfiles, Descripcion FROM Perfiles", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                CBEditarPerfil.DataSource = dt;
                CBEditarPerfil.DisplayMember = "Descripcion";   // Lo que se ve en el combo
                CBEditarPerfil.ValueMember = "ID_Perfiles";     // El valor interno (clave primaria)
            }
        }

        private void preCargarDatosUsuario()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
            {
                conn.Open();

                string query = "SELECT Nombre, Apellido, Email,pass, ID_Perfiles FROM Usuarios WHERE ID_Usuario = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", this.id_editar);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TBNombre.Text = reader["Nombre"].ToString();
                        TBApellido.Text = reader["Apellido"].ToString();
                        TBEmail.Text = reader["Email"].ToString();
                        TBPass.Text = reader["pass"].ToString();

                        CBEditarPerfil.SelectedValue = reader["ID_Perfiles"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                        this.Close();
                    }
                }
            }
        }
        private void CargarDatos(object sender, EventArgs e)
        {
            CargarTiposUsuario();
            preCargarDatosUsuario();

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

        private void agregarUsuario()
        {
            {
                if (CamposVacios(TBNombre, TBApellido, TBPass, TBEmail))
                {
                    MessageBox.Show("Rellena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string Nombre = TBNombre.Text;
                string Apellido = TBApellido.Text;
                string Email = TBEmail.Text;
                string Pass = TBPass.Text;
                

                int idPerfil = Convert.ToInt32(CBEditarPerfil.SelectedValue); // ID_Perfiles


                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                    {
                        conn.Open();

                        string query = @"UPDATE Usuarios 
                                      SET Nombre = @Nombre, 
                                          Apellido = @Apellido,     
                                          Email = @Email,   
                                          pass = @Pass, 
                                          ID_Perfiles = @idPerfil    
                                      WHERE ID_Usuario = @Id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", Apellido);
                            cmd.Parameters.AddWithValue("@Email", Email);
                            cmd.Parameters.AddWithValue("@pass", Pass);
                            cmd.Parameters.AddWithValue("@idPerfil", idPerfil);
                            cmd.Parameters.AddWithValue("@Id", this.id_editar);

                            cmd.ExecuteNonQuery();

                            formPrincipal.CargarUsuarios();
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
        }

        private void modificarUsuarioConfirmar(object sender, EventArgs e)
        {
            agregarUsuario();
        }
    }
}
