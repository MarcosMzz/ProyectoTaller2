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
    public partial class FormAgregarAutos : Form
    {
        private FormPrincipalAutos form1;
        public FormAgregarAutos(FormPrincipalAutos f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void cargarMarcas()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID_Marca, Descripcion FROM Marca", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                CBMarcas.DataSource = dt;
                CBMarcas.DisplayMember = "Descripcion";   // Lo que se ve en el combo
                CBMarcas.ValueMember = "ID_Marca";     // El valor interno (clave primaria)
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            TBModelo.Clear();
            TBStock.Clear();
            TBStock_Min.Clear();
           
            TBPrecio.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarMarcasVehiculos(object sender, EventArgs e)
        {
            cargarMarcas();
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

        private void agregarVehiculo(object sender, EventArgs e)
        {
            if (CamposVacios(TBModelo, TBStock, TBStock_Min, TBPrecio))
            {
                MessageBox.Show("Rellena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Modelo = TBModelo.Text;
            int Stock = Convert.ToInt32(TBStock.Text);
            int Stock_Min= Convert.ToInt32(TBStock_Min.Text);
            decimal Precio = decimal.Parse(TBPrecio.Text);
            int ID_Marca = Convert.ToInt32(CBMarcas.SelectedValue); // ID_Marca

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"INSERT INTO Vehiculos(Modelo, Precio, Stock, Stock_Min, ID_Marca) 
                                    VALUES (@Modelo, @Precio, @Stock, @Stock_Min, @ID_Marca)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Stock", Stock);
                        cmd.Parameters.AddWithValue("@Stock_Min", Stock_Min);
                        cmd.Parameters.AddWithValue("@Precio", Precio);
                        cmd.Parameters.AddWithValue("@ID_Marca", ID_Marca);
                        cmd.Parameters.AddWithValue("@Modelo", Modelo);

                        cmd.ExecuteNonQuery();



                    }
                }


                MessageBox.Show("Auto Agregado Correctamente");
                form1.CargarAutos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar vehículo: " + ex.Message);
            }
        }
    }
}
