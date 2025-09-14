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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2(this);
            ventana.Show(); 
        }

        public void AgregarFilasTabla(string id, string modelo, string stock, string estado, string marca, string precio, Image imagen)
        {
            dataGridView1.Rows.Add(id, modelo, stock, estado, marca, precio, imagen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar alguna fila para ser eliminada", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("¿Esta seguro que desea eliminar las filas seleccionadas?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
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

        private void CargarPerfiles()
        {
            string connStr = @"Server=localhost\SQLEXPRESS;Database=Concesionaria;Trusted_Connection=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Perfiles", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


    }
}
