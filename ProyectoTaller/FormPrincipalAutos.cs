using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // Para leer el connection string desde app.config


namespace ProyectoTaller
{
    public partial class FormPrincipalAutos : Form
    {
        public FormPrincipalAutos()
        {
            InitializeComponent();
        }


        public void CargarAutos(string where = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"SELECT 
                                ID_Auto,
                                Stock,
                                CASE WHEN Estado = 1 THEN 'Activo' ELSE 'Desactivado' END AS Estado,
                                Precio,
                                Modelo
                             FROM Vehiculos";

                    if (!string.IsNullOrEmpty(where))
                    {
                        query += " WHERE " + where;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGVehiculos.DataSource = dt;
                    DGVehiculos.AllowUserToAddRows = false;
                    DGVehiculos.ReadOnly = true;
                    DGVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cargarAutos(object sender, EventArgs e)
        {
            CargarAutos();
        }

        private void abrirFormAgregarAutos(object sender, EventArgs e)
        {
            FormAgregarAutos formAgregar = new FormAgregarAutos(this);
            formAgregar.Show();
        }

        private void abrirFormModificarAutos(object sender, EventArgs e)
        {
            if (DGVehiculos.SelectedRows.Count == 1) // Asumo que tu DataGrid se llama DGAutos
            {
                int id = Convert.ToInt32(DGVehiculos.SelectedRows[0].Cells["ID_Auto"].Value);

                // Pasamos 'this' (el FormPrincipalAutos) y el ID del auto
                FormModificarAutos formModif = new FormModificarAutos(this, id);
                formModif.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar UN vehículo para modificar");
            }
        }

        private void darDeBajaAutos(object sender, EventArgs e)
        {
            if (DGVehiculos.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in DGVehiculos.SelectedRows)
                {
                    // Asumo que la columna 2 es la columna 'Estado' mostrada
                    if (Convert.ToString(fila.Cells[2].Value) == "Desactivado")
                    {
                        MessageBox.Show("El vehículo " + Convert.ToString(fila.Cells["Modelo"].Value) + " ya estaba dado de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            // La columna 0 debe contener el ID_Auto
                            int id = Convert.ToInt32(fila.Cells[0].Value);

                            // Usamos la cadena de conexión fija
                            using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
                            {
                                conn.Open();

                                string query = @"UPDATE Vehiculos 
                                         SET Estado = 0
                                         WHERE ID_Auto = @Id";

                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Id", id);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al dar de baja el vehículo: " + ex.Message, "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Refrescar el DataGridView
                this.CargarAutos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar UNO o más vehículos para dar de baja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void darDeAltaAutos(object sender, EventArgs e)
        {
            if (DGVehiculos.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in DGVehiculos.SelectedRows)
                {
                    // Asumo que la columna 2 es la columna 'Estado' mostrada ("Activo" / "Desactivado")
                    if (Convert.ToString(fila.Cells[2].Value) == "Activo")
                    {
                        MessageBox.Show("El vehículo " + Convert.ToString(fila.Cells["Modelo"].Value) + " ya estaba dado de alta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            // La columna 0 debe contener el ID_Auto
                            int id = Convert.ToInt32(fila.Cells[0].Value);

                            // Usamos la cadena de conexión fija
                            using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
                            {
                                conn.Open();

                                string query = @"UPDATE Vehiculos 
                                         SET Estado = 1
                                         WHERE ID_Auto = @Id";

                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Id", id);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al dar de alta el vehículo: " + ex.Message, "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Refrescar el DataGridView
                this.CargarAutos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar UNO o más vehículos para dar de alta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
