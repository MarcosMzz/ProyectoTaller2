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
    public partial class FormModificarAutos : Form
    {
        // 1. Campos necesarios (ID del auto a modificar y referencia al principal)
        private int id_auto_editar;
        private FormPrincipalAutos formPrincipalAutos;
        public FormModificarAutos(FormPrincipalAutos principal, int id)
        {
            InitializeComponent();
            this.formPrincipalAutos = principal;
            this.id_auto_editar = id;
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

        private void preCargarDatosAuto()
        {
            // Consulta para obtener todos los datos del vehículo
            using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
            {
                conn.Open();

                string query = @"SELECT Modelo, Stock, Precio, ID_Marca
                                 FROM Vehiculos WHERE ID_Auto = @Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", this.id_auto_editar);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // 1. Cargar TextBoxes
                        TBModelo.Text = reader["Modelo"].ToString();
                        TBStock.Text = reader["Stock"].ToString();
                        TBPrecio.Text = reader["Precio"].ToString();

                        // 2. Cargar ComboBox: Le asignamos el valor ID_Marca al SelectedValue
                        // Convertir a string para la asignación (similar a cómo se hizo con Usuarios)
                        CBMarcas.SelectedValue = reader["ID_Marca"].ToString();

                        // NOTA: Si usas un CheckBox para el Estado, usa: CheckBoxEstado.Checked = (bool)reader["Estado"];

                    }
                    else
                    {
                        MessageBox.Show("Vehículo no encontrado.");
                        this.Close();
                    }
                }
            }
        }

        private void modificarAuto()
        {
            // 1. Validaciones
            if (CamposVacios(TBModelo, TBStock, TBPrecio))
            {
                MessageBox.Show("Rellena todos los campos para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Conversión de datos
            string modelo = TBModelo.Text;

            if (!int.TryParse(TBStock.Text, out int stock) ||
                !decimal.TryParse(TBPrecio.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal precio))
            {
                MessageBox.Show("Verifique que Stock y Precio sean números válidos.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asumimos que la Marca ya tiene un valor válido
            int idMarca = Convert.ToInt32(CBMarcas.SelectedValue);
            // int estado = CheckBoxEstado.Checked ? 1 : 0; // Si tuvieras un checkbox

            // 3. Ejecutar UPDATE
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionDB.ConnectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Vehiculos
                                     SET Modelo = @Modelo,
                                         Stock = @Stock,
                                         Precio = @Precio,
                                         ID_Marca = @IDMarca
                                     WHERE ID_Auto = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Modelo", modelo);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@IDMarca", idMarca);
                        cmd.Parameters.AddWithValue("@Id", this.id_auto_editar);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vehículo modificado correctamente.", "Éxito");

                // 4. Refrescar DataGrid del formulario principal (asumiendo que tiene un método CargarAutos)
                // ((FormPrincipalAutos)formPrincipalAutos).CargarAutos();
                formPrincipalAutos.CargarAutos();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar vehículo: " + ex.Message, "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cerrarForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarTodosLosCampos(object sender, EventArgs e)
        {
            TBModelo.Clear();
            TBStock.Clear();
            TBPrecio.Clear();
        }
        private void preCargarDatos(object sender, EventArgs e)
        {
            cargarMarcas();
            preCargarDatosAuto();
        }

        private void ModificarVehiculo(object sender, EventArgs e)
        {
            modificarAuto();
        }
    }
}
