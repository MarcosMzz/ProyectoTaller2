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
                                Stock_Min,
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
    }
}
