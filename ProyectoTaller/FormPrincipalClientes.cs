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
    public partial class FormPrincipalClientes : Form
    {

        public FormPrincipalClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void AbrirFormularioAgregarClientes(object sender, EventArgs e)
        {
            FormAgregarClientes formAgregar = new FormAgregarClientes(this); // le pasamos la instancia
            formAgregar.Show();
        }

        public void CargarClientes()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ID_Cliente, Nombre, Apellido, DNI, Email, Telefono, Direccion, FechaNacimiento, Baja FROM Cliente";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Crear nueva columna de texto para mostrar Estado
                    dt.Columns.Add("Estado", typeof(string));

                    // Llenar columna Estado según Baja
                    foreach (DataRow row in dt.Rows)
                    {
                        row["Estado"] = ((bool)row["Baja"]) ? "Activo" : "Inactivo";
                    }

                    // Configuración del DataGrid
                    DGClientes.AutoGenerateColumns = false;
                    DGClientes.AllowUserToAddRows = false; // quitar fila vacía
                    DGClientes.Columns.Clear();

                    // Definir columnas
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "ID_Cliente" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Apellido", DataPropertyName = "Apellido" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI", DataPropertyName = "DNI" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Teléfono", DataPropertyName = "Telefono" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dirección", DataPropertyName = "Direccion" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Nac.", DataPropertyName = "FechaNacimiento" });
                    DGClientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "Estado" });

                    // Asignar datos al DataGrid
                    DGClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }
        
    }
}
