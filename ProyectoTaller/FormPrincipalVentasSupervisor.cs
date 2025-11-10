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
    public partial class FormPrincipalVentasSupervisor : Form
    {
        public FormPrincipalVentasSupervisor()
        {
            InitializeComponent();
            this.cargarUsuariosCombo();
            this.CargarFechasDTP();
        }

        public void CargarVentasSupervisor(string condicion = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"
                                     SELECT 
                                         v.ID_Venta,
                                         v.FechaVenta AS Fecha,
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

                    // Si hay una condición, se agrega al final
                    if (!string.IsNullOrEmpty(condicion))
                    {
                        query += " WHERE " + condicion;
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DGVentasSupervisor.DataSource = dt;
                        DGVentasSupervisor.AllowUserToAddRows = false;
                        DGVentasSupervisor.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
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

        private void BGenerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.FileName = "Reporte_Ventas.pdf";

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
                    PdfPTable tabla = new PdfPTable(DGVentasSupervisor.Columns.Count);
                    tabla.WidthPercentage = 100;
                    tabla.SpacingBefore = 10;

                    // Encabezados
                    foreach (DataGridViewColumn columna in DGVentasSupervisor.Columns)
                    {
                        PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText, cabeceraFont));
                        celda.BackgroundColor = new BaseColor(200, 200, 200);
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.Padding = 5;
                        tabla.AddCell(celda);
                    }

                    decimal totalGeneral = 0;

                    // Filas
                    foreach (DataGridViewRow fila in DGVentasSupervisor.Rows)
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

        private void BBorrarFiltros_Click(object sender, EventArgs e)
        {
            this.CargarVentasSupervisor();
        }

        private void BControlesCruzados_Click(object sender, EventArgs e)
        {
            FormControlesCruzados formControles = new FormControlesCruzados(this);
            formControles.Show();
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

        private void BFiltrar_Click(object sender, EventArgs e)
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


                fechaHasta = fechaHasta.AddDays(1);
                

                condiciones.Add($"v.FechaVenta BETWEEN '{fechaDesde:yyyy-MM-dd}' AND '{fechaHasta:yyyy-MM-dd}'");

                // Unir condiciones con AND
                string condicionFinal = string.Join(" AND ", condiciones);

                // Llamar al método para cargar
                this.CargarVentasSupervisor(condicionFinal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar filtros: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BDescargarFactura(object sender, EventArgs e)
        {
            if (DGVentasSupervisor.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una y solo una fila de la venta que desea imprimir",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id_venta = Convert.ToInt32(DGVentasSupervisor.SelectedRows[0].Cells["ID_Venta"].Value);
                generarFactura(id_venta);
            }
        }

        private void generarFactura(int id)
        {
            // Crear objetos para guardar datos
            DataTable cabecera = new DataTable();
            DataTable detalle = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True"))
                {
                    conn.Open();

                    // ===== CONSULTA CABECERA =====
                    string queryCabecera = @"
                        SELECT 
                            vc.ID_venta,
                            vc.FechaVenta,
                            vc.Monto_Total,
                            c.Nombre,
                            c.Apellido,
                            c.DNI,
                            c.Email,
                            c.Direccion
                        FROM Ventas_Cabecera vc
                        INNER JOIN Cliente c ON vc.ID_cliente = c.ID_cliente
                        WHERE vc.ID_venta = @idVenta";

                    SqlCommand cmdCab = new SqlCommand(queryCabecera, conn);
                    cmdCab.Parameters.AddWithValue("@idVenta", id);
                    SqlDataAdapter daCab = new SqlDataAdapter(cmdCab);
                    daCab.Fill(cabecera);

                    // ===== CONSULTA DETALLE =====
                    string queryDetalle = @"
                        SELECT 
                            v.Modelo,
                            m.descripcion AS Marca,
                            v.Precio AS PrecioUnitario,
                            dv.Cantidad,
                            dv.SubTotal
                        FROM Detalle_Ventas dv
                        INNER JOIN Vehiculos v ON dv.ID_Auto = v.ID_Auto
                        INNER JOIN Marca m ON v.ID_Marca = m.ID_Marca
                        WHERE dv.ID_venta = @idVenta";

                    SqlCommand cmdDet = new SqlCommand(queryDetalle, conn);
                    cmdDet.Parameters.AddWithValue("@idVenta", id);
                    SqlDataAdapter daDet = new SqlDataAdapter(cmdDet);
                    daDet.Fill(detalle);
                }

                if (cabecera.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la venta especificada.");
                    return;
                }

                // === GENERAR PDF ===
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
                guardar.FileName = $"Factura_{id}.pdf";

                if (guardar.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(guardar.FileName, FileMode.Create));
                doc.Open();

                // Fuentes
                var fuenteTitulo = FontFactory.GetFont("Helvetica", 18, iTextSharp.text.Font.BOLD);
                var fuenteNormal = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.NORMAL);
                var fuenteNegrita = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.BOLD);

                // === ENCABEZADO ===
                Paragraph titulo = new Paragraph("FACTURA", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.SpacingAfter = 20;
                doc.Add(titulo);

                DataRow cab = cabecera.Rows[0];

                PdfPTable tablaEncabezado = new PdfPTable(2);
                tablaEncabezado.WidthPercentage = 100;
                tablaEncabezado.SetWidths(new float[] { 70, 30 });

                PdfPCell empresa = new PdfPCell(new Phrase("XPORT\nCUIT: 12-12345678-9\nDirección: Yrigoyen 341\nTel: (011) 1234-5678", fuenteNormal));
                empresa.Border = 0;
                tablaEncabezado.AddCell(empresa);

                PdfPCell datosFactura = new PdfPCell(new Phrase(
                    $"Fecha: {Convert.ToDateTime(cab["FechaVenta"]):dd/MM/yyyy}\nFactura N°: {cab["ID_venta"]}", fuenteNormal));
                datosFactura.Border = 0;
                datosFactura.HorizontalAlignment = Element.ALIGN_RIGHT;
                tablaEncabezado.AddCell(datosFactura);

                doc.Add(tablaEncabezado);
                doc.Add(new Paragraph("\n"));

                // === DATOS CLIENTE ===
                PdfPTable tablaCliente = new PdfPTable(1);
                tablaCliente.WidthPercentage = 100;
                tablaCliente.SpacingAfter = 10;

                PdfPCell tituloCliente = new PdfPCell(new Phrase("Datos del Cliente", fuenteNegrita));
                tituloCliente.BackgroundColor = new BaseColor(230, 230, 230);
                tituloCliente.Border = 0;
                tablaCliente.AddCell(tituloCliente);

                PdfPCell datosCliente = new PdfPCell(new Phrase(
                    $"Nombre: {cab["Nombre"]} {cab["Apellido"]}\n" +
                    $"DNI: {cab["DNI"]}\n" +
                    $"Email: {cab["Email"]}\n" +
                    $"Dirección: {cab["Direccion"]}", fuenteNormal));
                datosCliente.Border = 0;
                tablaCliente.AddCell(datosCliente);

                doc.Add(tablaCliente);

                // === DETALLE DE PRODUCTOS ===
                PdfPTable tabla = new PdfPTable(5); // Modelo, Marca, Precio, Cantidad, SubTotal
                tabla.WidthPercentage = 100;
                tabla.SpacingBefore = 10;

                string[] headers = { "Modelo", "Marca", "Precio Unitario", "Cantidad", "SubTotal" };
                foreach (var h in headers)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(h, fuenteNegrita));
                    celda.BackgroundColor = new BaseColor(240, 240, 240);
                    celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabla.AddCell(celda);
                }

                foreach (DataRow row in detalle.Rows)
                {
                    tabla.AddCell(new Phrase(row["Modelo"].ToString(), fuenteNormal));
                    tabla.AddCell(new Phrase(row["Marca"].ToString(), fuenteNormal));
                    tabla.AddCell(new Phrase($"{Convert.ToDecimal(row["PrecioUnitario"]):N2}", fuenteNormal));
                    tabla.AddCell(new Phrase(row["Cantidad"].ToString(), fuenteNormal));
                    tabla.AddCell(new Phrase($"{Convert.ToDecimal(row["SubTotal"]):N2}", fuenteNormal));
                }

                doc.Add(tabla);

                // === TOTAL ===
                Paragraph totalTxt = new Paragraph($"TOTAL: ${Convert.ToDecimal(cab["Monto_Total"]):N2}", fuenteTitulo);
                totalTxt.Alignment = Element.ALIGN_RIGHT;
                doc.Add(totalTxt);

                // === PIE ===
                Paragraph pie = new Paragraph("\nGracias por su compra.", fuenteNormal);
                pie.Alignment = Element.ALIGN_CENTER;
                pie.SpacingBefore = 20;
                doc.Add(pie);

                doc.Close();
                MessageBox.Show("Factura generada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar factura: " + ex.Message);
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
