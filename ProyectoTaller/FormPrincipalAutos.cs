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

        private void button1_Click(object sender, EventArgs e)
        {
            FormAgregarAutos ventana = new FormAgregarAutos(this);
            ventana.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (DGAutos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar alguna fila para ser eliminada", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Esta seguro que desea eliminar las filas seleccionadas?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DGAutos.SelectedRows)
                {
                    DGAutos.Rows.Remove(row);
                }
            }*/
        }

        private void mostrarAgregarClientes(object sender, EventArgs e)
        {
            // Crear instancia del form de clientes
            FormPrincipalClientes formClientes = new FormPrincipalClientes();

            // Mostrarlo
            formClientes.Show();
        }

        private void cargarDatosPrueba(object sender, EventArgs e)
        {

        }


        public void CargarAutos()
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
                             FROM Vehiculos;";

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
