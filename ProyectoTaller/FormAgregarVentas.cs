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
    public partial class FormAgregarVentas : Form
    {

        private const string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True";
        private decimal precioAutoSeleccionado = 0.00m;
        public FormAgregarVentas()
        {
            InitializeComponent();
        }

        // Lista que actúa como el "carrito" de compras
        private List<DetalleTemporal> carrito = new List<DetalleTemporal>();

        // Necesario para almacenar el precio del auto seleccionado antes de agregarlo

        // Necesitas un método para cargar los vehículos en el CBAuto
        private void CargarVehiculos()
        {
            try
            {
                CBAuto.SelectedIndexChanged -= CBAuto_SelectedIndexChanged;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // La consulta ya excluye vehículos sin stock (V.Stock > 0)
                    string query = @"SELECT V.ID_Auto, V.Modelo, V.Precio, M.Descripcion AS Marca
                             FROM Vehiculos V 
                             INNER JOIN Marca M ON V.ID_Marca = M.ID_Marca
                             WHERE V.Estado = 1 AND V.Stock > 0"; // <-- Esta es la clave

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CBAuto.DataSource = dt;
                    CBAuto.DisplayMember = "Modelo";
                    CBAuto.ValueMember = "ID_Auto";
                    CBAuto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                // NO mostramos un MessageBox. Solo registramos el error internamente (si tienes un log)
                // o lo dejamos sin notificar al usuario, para que no lo moleste.
                // Si la carga falla, el ComboBox simplemente quedará vacío.
                // Console.WriteLine($"Error al cargar vehículos: {ex.Message}"); 
            }
            finally
            {
                // 2. REACTIVAR el evento
                CBAuto.SelectedIndexChanged += CBAuto_SelectedIndexChanged;
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Necesitamos el DNI y el ID_Cliente para la venta final.
                    string query = @"SELECT ID_Cliente, DNI, Nombre, Apellido, Email
                             FROM Cliente
                             WHERE Baja = 1"; // Asumiendo que 'Baja = 0' significa activo

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Asegúrate de desactivar el evento antes de manipular el control
                    CBDni.SelectedIndexChanged -= CBDni_SelectedIndexChanged;

                    CBDni.DataSource = dt;
                    CBDni.DisplayMember = "DNI"; // Lo que el usuario ve
                    CBDni.ValueMember = "ID_Cliente"; // El valor que usaremos para la venta final
                    CBDni.SelectedIndex = -1;

                    // Reactivar el evento
                    CBDni.SelectedIndexChanged += CBDni_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBDni_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar campos si no hay selección válida.
            if (CBDni.SelectedValue == null || CBDni.SelectedValue == DBNull.Value || CBDni.SelectedIndex == -1)
            {
                TBNombre.Text = string.Empty;
                TBApellido.Text = string.Empty;
                TBEmail.Text = string.Empty;
                return;
            }

            // Intentamos obtener el objeto DataRowView que contiene todos los datos.
            if (CBDni.SelectedItem is DataRowView drv)
            {
                try
                {
                    // Asignar los valores a los TextBoxes. Los nombres de columna deben coincidir con la query.

                    // Asumimos que las columnas en el DataTable se llaman "Nombre", "Apellido", "Email"
                    TBNombre.Text = drv["Nombre"].ToString();
                    TBApellido.Text = drv["Apellido"].ToString();
                    TBEmail.Text = drv["Email"].ToString();
                }
                catch (Exception ex)
                {
                    // En caso de que falle la conversión o la columna no exista en el DataTable.
                    MessageBox.Show($"Error al cargar los datos del cliente: {ex.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Limpiar si falla
                    TBNombre.Text = string.Empty;
                    TBApellido.Text = string.Empty;
                    TBEmail.Text = string.Empty;
                }
            }
        }
        private void preCargarDatos(object sender, EventArgs e)
        {
            UIStyles.AddHoverEffectToAllButtons(this);
            CargarVehiculos();
            CargarClientes();
            LNombreVendedor.Text = Sesion.Nombre + " " +Sesion.Apellido;
        }

        private void CBAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Validación y Extracción Segura del ID
            if (CBAuto.SelectedValue == null || CBAuto.SelectedValue == DBNull.Value || CBAuto.SelectedIndex == -1)
            {
                TBPrecio.Text = string.Empty;
                precioAutoSeleccionado = 0.00m;
                return;
            }

            // Extracción Segura (Solución al InvalidCastException)
            int idAuto = 0;
            if (!int.TryParse(CBAuto.SelectedValue.ToString(), out idAuto))
            {
                MessageBox.Show("Error: No se pudo obtener el ID del vehículo.", "Error Crítico");
                return;
            }

            // === 2. Consulta y Carga del Precio desde la DB ===
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Solo necesitamos el Precio.
                    string query = "SELECT Precio FROM Vehiculos WHERE ID_Auto = @ID_Auto";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Auto", idAuto);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Extraemos el valor decimal de la primera columna (índice 0)
                                precioAutoSeleccionado = reader.GetDecimal(0);

                                // Mostramos el precio en el TextBox.
                                TBPrecio.Text = precioAutoSeleccionado.ToString("N2");
                            }
                            else
                            {
                                // Si el ID no existe en la tabla de Vehículos.
                                TBPrecio.Text = "No encontrado";
                                precioAutoSeleccionado = 0.00m;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores de conexión o de consulta SQL.
                MessageBox.Show($"Error al cargar el precio: {ex.Message}", "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBPrecio.Text = string.Empty;
                precioAutoSeleccionado = 0.00m;
            }
        }


        private void agregarProducto(object sender, EventArgs e)
        {
            // === 1. Validación de Entradas ===
            if (CBAuto.SelectedValue == null || CBAuto.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Debe seleccionar un vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)NUDCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            //Obtenemos ID de vehiculo
            int idAutoSeleccionado = 0;
            // Utilizamos el TryParse para la conversión segura, que previene el InvalidCastException

            if (!int.TryParse(CBAuto.SelectedValue.ToString(), out idAutoSeleccionado))
            {
                MessageBox.Show("Error al obtener el ID del vehículo. Contacte a soporte.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ------------------------------------------------------------------

            string modelo = CBAuto.Text;
            string marca = string.Empty;

         
            //2: Extracción robusta del Precio
           
            decimal precioUnitario;
            // Usamos NumberStyles.Currency para aceptar el símbolo '$' y otros formatos de moneda,
            // garantizando que la conversión funcione con 13.500.000,00 o $13500000.00
            if (!decimal.TryParse(TBPrecio.Text,
                                  System.Globalization.NumberStyles.Currency,
                                  System.Globalization.CultureInfo.CurrentCulture,
                                  out precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("El precio del vehículo no es válido o es cero. Seleccione el vehículo de nuevo.", "Error de Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // ------------------------------------------------------------------


            // === 2. CONTROL DE STOCK (Conexión a DB) y obtención de Marca ===
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1.1 Consulta para obtener Stock y Marca
                    string stockQuery = @"SELECT Stock, M.Descripcion AS Marca 
                                     FROM Vehiculos V 
                                     INNER JOIN Marca M ON V.ID_Marca = M.ID_Marca
                                     WHERE V.ID_Auto = @ID_Auto";

                    using (SqlCommand cmd = new SqlCommand(stockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_Auto", idAutoSeleccionado);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int stockActual = reader.GetInt32(0);
                                marca = reader.GetString(1);

                                // 1.2 Calcular Stock comprometido en el carrito (Importante!)
                                int stockComprometido = carrito.Where(d => d.ID_Auto == idAutoSeleccionado).Sum(d => d.Cantidad);
                                int stockDisponibleReal = stockActual - stockComprometido;

                                if (cantidad > stockDisponibleReal)
                                {
                                    MessageBox.Show($"Stock insuficiente. Disponible: {stockDisponibleReal}", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Salir si no hay stock
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al obtener datos del vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar stock: " + ex.Message, "Error de DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // === 3. GESTIÓN DEL CARRITO (Lista en memoria) ===
            DetalleTemporal itemExistente = carrito.FirstOrDefault(d => d.ID_Auto == idAutoSeleccionado);

            if (itemExistente != null)
            {
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                DetalleTemporal nuevoItem = new DetalleTemporal
                {
                    ID_Auto = idAutoSeleccionado,
                    Modelo = modelo,
                    Marca = marca,
                    PrecioUnitario = precioUnitario,
                    Cantidad = cantidad
                };
                carrito.Add(nuevoItem);
            }

            // === 4. ACTUALIZACIÓN DE INTERFAZ ===
            RecalcularTotal();

            // Refrescar el DataGridView
            DGProductosAgregados.DataSource = null;
            DGProductosAgregados.DataSource = carrito;

            // Limpiar entradas para el próximo item
            NUDCantidad.Value = 0;

            // Desactivar/Reactivar evento para evitar que SelectedIndex = -1 dispare la carga
            CBAuto.SelectedIndexChanged -= CBAuto_SelectedIndexChanged;
            CBAuto.SelectedIndex = -1;
            CBAuto.SelectedIndexChanged += CBAuto_SelectedIndexChanged;
        }

        // Función auxiliar para recalcular el Total General
        private void RecalcularTotal()
        {
            decimal totalVenta = carrito.Sum(d => d.SubTotal);
            // Asumo que tu Label se llama lblPrecioFinalTotal o similar.
            LTotal.Text = $"Total: {totalVenta.ToString("C2")}";
        }

        private void BTNEliminarProducto_Click(object sender, EventArgs e)
        {
            // === 1. Validación de Selección ===
            // Verificar que haya al menos una fila seleccionada en el DataGrid
            if (DGProductosAgregados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila de la lista para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pedir confirmación al usuario (buena práctica de UX)
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto del carrito?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return; // El usuario canceló la acción
            }

            // === 2. Obtener el Ítem Seleccionado ===
            // Tomamos la primera fila seleccionada
            DataGridViewRow filaSeleccionada = DGProductosAgregados.SelectedRows[0];

            // El DataGrid está enlazado a la lista 'carrito', así que obtenemos el objeto DetalleTemporal de esa fila.
            // Usamos el casting para convertir la DataBoundItem de la fila a nuestro objeto DetalleTemporal.
            DetalleTemporal itemAEliminar = filaSeleccionada.DataBoundItem as DetalleTemporal;

            if (itemAEliminar != null)
            {
                // === 3. Remoción del Carrito (Lista en memoria) ===
                carrito.Remove(itemAEliminar);

                // === 4. Actualización de la Interfaz ===

                // A. Recalcular el Total
                RecalcularTotal();

                // B. Refrescar el DataGridView
                
                DGProductosAgregados.DataSource = null;
                DGProductosAgregados.DataSource = carrito;


            }
        }

        private void limparDatosVehiculo(object sender, EventArgs e)
        {
            // Limpiamos los TextBoxes
            TBPrecio.Text = string.Empty;
            NUDCantidad.Value = 0;

            // Desactivar/Reactivar evento para limpiar el ComboBox sin disparar la lógica de carga
            CBAuto.SelectedIndexChanged -= CBAuto_SelectedIndexChanged;
            CBAuto.SelectedIndex = -1;
            CBAuto.SelectedIndexChanged += CBAuto_SelectedIndexChanged;
        }

        private void limparDatosCliente()
        {
            // Limpiamos los TextBoxes
            TBNombre.Text = string.Empty;
            TBApellido.Text = string.Empty;
            TBEmail.Text = string.Empty;

            // Desactivar/Reactivar evento para limpiar el ComboBox sin disparar la lógica
            CBDni.SelectedIndexChanged -= CBDni_SelectedIndexChanged;
            CBDni.SelectedIndex = -1;
            CBDni.SelectedIndexChanged += CBDni_SelectedIndexChanged;
        }

        private void limparCarrito()
        {
            carrito.Clear();
            DGProductosAgregados.DataSource = null;
            RecalcularTotal();
        }

        private void limpiarTodoElFormulario()
        {
            limparDatosCliente();
            limparDatosVehiculo(null, null);
            limparCarrito();
        }


        private void cancelarVenta(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar la venta y borrar todos los productos y datos del cliente?",
                                            "Confirmar Cancelación",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                limpiarTodoElFormulario();

                MessageBox.Show("Venta cancelada. Formulario reiniciado.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void finalizarVenta(object sender, EventArgs e)
        {
            // === 0. VALIDACIONES CRÍTICAS ===

            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío. Agregue productos para finalizar la venta.", "Error de Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 0.1 Obtener ID del Cliente (Necesario y validado por la interfaz)
            if (CBDni.SelectedValue == null || CBDni.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Debe seleccionar un Cliente para completar la venta.", "Error de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCliente = 0; // Inicializamos a 0
            if (!int.TryParse(CBDni.SelectedValue.ToString(), out idCliente) || idCliente <= 0)
            {
                // Esto captura la InvalidCastException y el caso de ID inválido.
                MessageBox.Show("El ID de cliente es inválido. Seleccione el DNI nuevamente.", "Error de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 0.2 Obtener ID del Vendedor (Desde la Clase Sesion)
            int idUsuarioVendedor = Sesion.UsuarioId;

            if (idUsuarioVendedor <= 0)
            {
                MessageBox.Show("Error: ID de Vendedor no válido. Inicie sesión nuevamente.", "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // El monto total ya está calculado en RecalcularTotal() y Sum()
            decimal montoTotal = carrito.Sum(d => d.SubTotal);

            // === 1. INICIO DE LA TRANSACCIÓN ===
            SqlTransaction transaction = null;
            int idVentaCabecera = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction(); // *** BLOQUEA CAMBIOS HASTA COMMIT ***

                    // === 2. INSERTAR CABECERA y CAPTURAR ID_Venta ===
                    // Monto_Total se inserta como 0 (DEFAULT) o el valor calculado, y luego se actualiza.
                    string cabeceraQuery = @"INSERT INTO Ventas_Cabecera (FechaVenta, Monto_Total, ID_Usuario, ID_Cliente)
                                     VALUES (GETDATE(), @MontoTotal, @IDUsuario, @IDCliente);
                                     SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdCabecera = new SqlCommand(cabeceraQuery, conn, transaction))
                    {
                        // Usamos el MontoTotal calculado aquí, aunque lo actualizaremos después.
                        cmdCabecera.Parameters.AddWithValue("@MontoTotal", montoTotal);
                        cmdCabecera.Parameters.AddWithValue("@IDUsuario", idUsuarioVendedor);
                        cmdCabecera.Parameters.AddWithValue("@IDCliente", idCliente);

                        // Ejecutamos y capturamos el ID_Venta
                        idVentaCabecera = Convert.ToInt32(cmdCabecera.ExecuteScalar());
                    }

                    // === 3. BUCLE: INSERTAR DETALLES Y ACTUALIZAR STOCK ===
                    string detalleQuery = @"INSERT INTO Detalle_Ventas (ID_Venta, ID_Auto, Cantidad, SubTotal)
                                    VALUES (@IDVenta, @IDAuto, @Cantidad, @SubTotal);";

                    string stockUpdateQuery = @"UPDATE Vehiculos SET Stock = Stock - @Cantidad 
                                        WHERE ID_Auto = @IDAuto AND Stock >= @Cantidad;"; // Agregamos control final

                    foreach (var item in carrito)
                    {
                        // A. Insertar Detalle (asociado al ID_Venta capturado)
                        using (SqlCommand cmdDetalle = new SqlCommand(detalleQuery, conn, transaction))
                        {
                            cmdDetalle.Parameters.AddWithValue("@IDVenta", idVentaCabecera);
                            cmdDetalle.Parameters.AddWithValue("@IDAuto", item.ID_Auto);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                            cmdDetalle.Parameters.AddWithValue("@SubTotal", item.SubTotal);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        // B. Actualizar Stock (Controlando que no quede negativo)
                        using (SqlCommand cmdStock = new SqlCommand(stockUpdateQuery, conn, transaction))
                        {
                            cmdStock.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                            cmdStock.Parameters.AddWithValue("@IDAuto", item.ID_Auto);

                            if (cmdStock.ExecuteNonQuery() == 0)
                            {
                                // Si ExecuteNonQuery devuelve 0, significa que la condición WHERE no se cumplió 
                                // (ej. el Stock ya es menor a la cantidad)
                                throw new Exception($"Error de stock: No se pudo actualizar el stock para el vehículo {item.Modelo}. Es posible que el stock haya cambiado.");
                            }
                        }
                    }

                    // === 4. (OPCIONAL) ACTUALIZAR MONTO FINAL EN CABECERA ===
                    // Si insertaste 0 inicialmente, ahora lo actualizas con el monto real calculado.
                    string updateMontoQuery = @"UPDATE Ventas_Cabecera SET Monto_Total = @MontoFinal 
                                        WHERE ID_Venta = @IDVenta;";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateMontoQuery, conn, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@MontoFinal", montoTotal);
                        cmdUpdate.Parameters.AddWithValue("@IDVenta", idVentaCabecera);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // === 5. COMMIT (Confirmar) ===
                    transaction.Commit();
                    MessageBox.Show($"Venta Nro. {idVentaCabecera} registrada con éxito. Stock actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Llamamos a la función de limpieza para reiniciar el formulario
                    limpiarTodoElFormulario();
                }
                catch (Exception ex)
                {
                    // === 6. ROLLBACK (Revertir) ===
                    try
                    {
                        transaction?.Rollback(); // Revertir todos los cambios si algo falló.
                    }
                    catch (Exception exRollback)
                    {
                        MessageBox.Show("Error crítico al intentar revertir la venta. Contacte a soporte.", "FATAL DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show($"La venta falló. Error: {ex.Message}. Se han revertido todos los cambios en la base de datos.",
                                    "Transacción Fallida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void mostrarFormVentasTotales(object sender, EventArgs e)
        {
            // 1. Obtenemos una referencia al FormPrincipal (el padre MDI)
            FormPrincipal padre = this.MdiParent as FormPrincipal;

            if (padre != null)
            {
                // 2. Le pedimos al padre que cierre lo actual y abra el formulario de destino.
                
                padre.abrirForm(new FormPrincipalVentasVendedor());

            }
        }
    }
    
}
