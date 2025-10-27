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
    public partial class FormFiltrarVentasSupervisor : Form
    {
        FormPrincipalVentasSupervisor formPadre;
        public FormFiltrarVentasSupervisor(FormPrincipalVentasSupervisor formPadre)
        {
            InitializeComponent();
            this.cargarUsuariosCombo();
            this.CargarFechasDTP();
            this.formPadre = formPadre;
        }

        private void cargarUsuariosCombo()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
            {
                conn.Open();
                string query = "SELECT ID_Usuario, Nombre + ' ' + Apellido AS NombreCompleto FROM Usuarios  WHERE ID_Perfiles = 3";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboUsuarios.DataSource = dt;
                comboUsuarios.DisplayMember = "NombreCompleto";
                comboUsuarios.ValueMember = "ID_Usuario";
                comboUsuarios.SelectedIndex = -1;
                comboUsuarios.Text = "Seleccione un vendedor";
            }
        }
        private void CargarFechasDTP()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT MIN(FechaVenta) AS FechaMasAntigua FROM Ventas_Cabecera";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != DBNull.Value)
                        {
                            DTPDesde.Value = Convert.ToDateTime(resultado);
                        }
                        else
                        {
                            // Si no hay ventas registradas, poner la fecha actual
                            DTPDesde.Value = DateTime.Today;
                        }
                    }
                    DTPHasta.Value = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la fecha más antigua: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> condiciones = new List<string>();

                // Si seleccionó un vendedor
                if (comboUsuarios.SelectedIndex != -1)
                {
                    int idVendedor = Convert.ToInt32(comboUsuarios.SelectedValue);
                    condiciones.Add($"v.ID_Usuario = {idVendedor}");
                }

                // Rango de fechas
                DateTime fechaDesde = DTPDesde.Value.Date;
                DateTime fechaHasta = DTPHasta.Value.Date;

                // Si querés incluir todo el día "hasta", sumá un día menos un segundo
                fechaHasta = fechaHasta.AddDays(1).AddSeconds(-1);

                condiciones.Add($"v.FechaVenta BETWEEN '{fechaDesde:yyyy-MM-dd}' AND '{fechaHasta:yyyy-MM-dd}'");

                // Unir condiciones con AND
                string condicionFinal = string.Join(" AND ", condiciones);

                // Llamar al método del formulario padre
                formPadre.CargarVentasSupervisor(condicionFinal);

                // Cerrar el formulario de filtros
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
