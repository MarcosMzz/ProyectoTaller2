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
    public partial class FormPrincipalUsuarios : Form
    {

        public FormPrincipalUsuarios()
        {
            InitializeComponent();
        }

        private void inicializarTablaUsuarios(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"SELECT 
                                u.ID_Usuario,
                                u.Nombre,
                                u.Apellido,
                                u.Email,
                                CASE WHEN u.Baja = 1 THEN 'Activo' ELSE 'Desactivado' END AS Estado,
                                p.Descripcion AS Perfil,
                                u.FechaNacimiento
                             FROM Usuarios u
                             INNER JOIN Perfiles p ON u.ID_Perfiles = p.ID_Perfiles;";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGUusarios.DataSource = dt;
                    DGUusarios.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormAgregarCliente(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregar = new FormAgregarUsuario(this);
            formAgregar.ShowDialog(); // lo mostramos modal
        }

        private void abrirFormModificarUsuarios(object sender, EventArgs e)
        {
            if (DGUusarios.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DGUusarios.SelectedRows[0].Cells["ID_Usuario"].Value);

                FormModificarUsuario formModif = new FormModificarUsuario(this, id);
                formModif.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar UN cliente para modificar");
            }
        }
        private void DarDeBajaUsuarios(object sender, EventArgs e)
        {
            if (DGUusarios.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in DGUusarios.SelectedRows)
                {
                    if (Convert.ToString(fila.Cells["Estado"].Value) == "Desactivado")
                    {
                        MessageBox.Show("El usuario " + Convert.ToString(fila.Cells[1].Value) + " ya habia sido dado de baja");
                    }
                    else
                    {
                        int id = Convert.ToInt32(fila.Cells[0].Value);

                        using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                        {
                            conn.Open();

                            string query = @"UPDATE Usuarios 
                                          SET Baja = 0
                                         WHERE ID_Usuario = @Id";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                this.CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para dar de baja");
            }
        }

        private void DarDeAltaUsuarios(object sender, EventArgs e)
        {
            if (DGUusarios.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in DGUusarios.SelectedRows)
                {
                    if (Convert.ToString(fila.Cells["Estado"].Value) == "Activo")
                    {
                        MessageBox.Show("El usuario " + Convert.ToString(fila.Cells[1].Value) + " ya habia sido dado de alta");
                    }
                    else
                    {
                        int id = Convert.ToInt32(fila.Cells[0].Value);

                        using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                        {
                            conn.Open();

                            string query = @"UPDATE Usuarios 
                                          SET Baja = 1
                                         WHERE ID_Usuario = @Id";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", id);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                this.CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar UN cliente para dar de alta");
            }
        }
    }


}
