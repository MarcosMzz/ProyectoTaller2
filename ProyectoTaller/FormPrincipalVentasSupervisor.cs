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
    public partial class FormPrincipalVentasSupervisor : Form
    {
        public FormPrincipalVentasSupervisor()
        {
            InitializeComponent();
        }

        private void CargarVentasSupervisor()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    v.ID_Venta,
                    ve.Modelo AS Auto,
                    u.Nombre + ' ' + u.Apellido AS Vendedor,
                    c.Nombre + ' ' + c.Apellido AS Cliente,
                    dv.Cantidad,
                    dv.SubTotal,
                    v.Monto_Total
                FROM Ventas_Cabecera v
                INNER JOIN Detalle_Ventas dv ON v.ID_Venta = dv.ID_Venta
                INNER JOIN Vehiculos ve ON dv.ID_Auto = ve.ID_Auto
                INNER JOIN Usuarios u ON v.ID_Usuario = u.ID_Usuario
                INNER JOIN Cliente c ON v.ID_Cliente = c.ID_Cliente";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DGVentasSupervisor.DataSource = dt;
                        DGVentasSupervisor.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatosVentaSup(object sender, EventArgs e)
        {
            CargarVentasSupervisor();
        }
    }
}
