using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace ProyectoTaller
{
    public partial class FormPrincipalVentasVendedor : Form
    {
        public FormPrincipalVentasVendedor()
        {
            InitializeComponent();
            this.cargarDTP();
        }

        private void cargarDTP()
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void CargarVentasVendedor()
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
                                    INNER JOIN Cliente c ON v.ID_Cliente = c.ID_Cliente
                                    WHERE v.ID_Usuario = @UsuarioId";

                    DateTime fechaDesde = dateTimePicker1.Value.Date;
                    DateTime fechaHasta = dateTimePicker1.Value.Date.AddDays(1);

                    query += " AND " + $"v.FechaVenta BETWEEN '{fechaDesde:yyyy-MM-dd}' AND '{fechaHasta:yyyy-MM-dd}'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsuarioId", Sesion.UsuarioId);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            DGVentasVendedor.DataSource = dt;
                            DGVentasVendedor.AllowUserToAddRows = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas del vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarVentasVendedor(object sender, EventArgs e)
        {
            CargarVentasVendedor();
        }

        private void abrirFormAgregarVentas(object sender, EventArgs e)
        {
            FormPrincipal padre = this.MdiParent as FormPrincipal;

            if (padre != null)
            {
                // Pedimos al padre que cierre el listado y abra la vista de carrito
                padre.abrirForm(new FormAgregarVentas());

            }
        }
        private void BGenerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.FileName = "Reporte_Ventas_Vendedor.pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(guardar.FileName, FileMode.Create));
                    doc.Open();

                    // Fuente
                    Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    Font subtituloFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    Font cabeceraFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                    Font cuerpoFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                    // Título
                    Paragraph titulo = new Paragraph("Reporte de Ventas", tituloFont);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 5;
                    doc.Add(titulo);

                    // Fecha del reporte
                    Paragraph fecha = new Paragraph("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), subtituloFont);
                    fecha.Alignment = Element.ALIGN_RIGHT;
                    fecha.SpacingAfter = 20;
                    doc.Add(fecha);

                    // Tabla
                    PdfPTable tabla = new PdfPTable(DGVentasVendedor.Columns.Count);
                    tabla.WidthPercentage = 100;
                    tabla.SpacingBefore = 10;

                    // Encabezados
                    foreach (DataGridViewColumn columna in DGVentasVendedor.Columns)
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText, cabeceraFont));
                        celda.BackgroundColor = new BaseColor(200, 200, 200);
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.Padding = 5;
                        tabla.AddCell(celda);
                    }

                    decimal totalGeneral = 0;

                    // Filas
                    foreach (DataGridViewRow fila in DGVentasVendedor.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                string texto = celda.Value?.ToString() ?? "";
                                PdfPCell cell = new PdfPCell(new Phrase(texto, cuerpoFont));
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.Padding = 5;
                                tabla.AddCell(cell);
                            }

                            // Sumar totales
                            if (fila.Cells["Monto_Total"].Value != null &&
                                decimal.TryParse(fila.Cells["Monto_Total"].Value.ToString(), out decimal monto))
                            {
                                totalGeneral += monto;
                            }
                        }
                    }

                    doc.Add(tabla);

                    // Total general
                    Paragraph total = new Paragraph("\nTotal General de Ventas: $" + totalGeneral.ToString("N2"), subtituloFont);
                    total.Alignment = Element.ALIGN_RIGHT;
                    total.SpacingBefore = 15;
                    doc.Add(total);

                    // Pie de página
                    Paragraph pie = new Paragraph("\nXPORT", FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9));
                    pie.Alignment = Element.ALIGN_CENTER;
                    doc.Add(pie);

                    doc.Close();
                    MessageBox.Show("Reporte PDF generado correctamente en:\n" + guardar.FileName, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message);
                }
            }
        }
    }
}
