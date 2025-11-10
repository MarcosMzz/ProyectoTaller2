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
                string nombre = Convert.ToString(DGUusarios.SelectedRows[0].Cells["Nombre"].Value);

                //Evitar que el usuario logueado se modifique a sí mismo
                if (id == Sesion.UsuarioId)
                {
                    MessageBox.Show("No puedes modificar tus propios datos desde este menú.",
                                    "Acción no permitida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                //Evitar que un admin modifique a otro admin
                string perfil = Convert.ToString(DGUusarios.SelectedRows[0].Cells["Perfil"].Value);
                if (Sesion.Rol == "Administrador" && perfil == "Administrador")
                {
                    MessageBox.Show($"No puedes modificar a otro administrador ({nombre}).",
                                    "Acción no permitida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                //Si pasa las validaciones, abre el formulario normalmente
                FormModificarUsuario formModif = new FormModificarUsuario(this, id);
                formModif.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar UN usuario para modificar.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void DarDeBajaUsuarios(object sender, EventArgs e)
        {
            if (DGUusarios.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in DGUusarios.SelectedRows)
                {
                    int id = Convert.ToInt32(fila.Cells["ID_Usuario"].Value);
                    string nombre = Convert.ToString(fila.Cells["Nombre"].Value);
                    string estado = Convert.ToString(fila.Cells["Estado"].Value);
                    string perfil = Convert.ToString(fila.Cells["Perfil"].Value); // ← viene de tu consulta SQL

                    // 🚫 1. Evitar que el admin se dé de baja a sí mismo
                    if (id == Sesion.UsuarioId)
                    {
                        MessageBox.Show("No puedes darte de baja a ti mismo.",
                                        "Acción no permitida",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        continue;
                    }

                    // 🚫 2. Evitar que un admin dé de baja a otro admin
                    if (Sesion.Rol == "Administrador" && perfil == "Administrador")
                    {
                        MessageBox.Show($"No puedes dar de baja a otro administrador ({nombre}).",
                                        "Acción no permitida",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        continue;
                    }

                    // ⚠️ 3. Verificar si ya está desactivado
                    if (estado == "Desactivado")
                    {
                        MessageBox.Show($"El usuario {nombre} ya había sido dado de baja.",
                                        "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        continue;
                    }

                    // ✅ 4. Actualizar el estado en la base de datos
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

                // 🔄 Recargar la grilla para reflejar los cambios
                this.CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para dar de baja.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
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
