namespace ProyectoTaller
{
    partial class FormAgregarVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PanelProducto = new System.Windows.Forms.Panel();
            this.NUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNAgregarProducto = new System.Windows.Forms.Button();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBAuto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelCliente = new System.Windows.Forms.Panel();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBDni = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGProductosAgregados = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.LNombreVendedor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BTNCancelarVenta = new System.Windows.Forms.Button();
            this.BTNFinalizarVenta = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductosAgregados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // PanelProducto
            // 
            this.PanelProducto.Controls.Add(this.NUDCantidad);
            this.PanelProducto.Controls.Add(this.BTNLimpiar);
            this.PanelProducto.Controls.Add(this.BTNAgregarProducto);
            this.PanelProducto.Controls.Add(this.TBPrecio);
            this.PanelProducto.Controls.Add(this.label10);
            this.PanelProducto.Controls.Add(this.label9);
            this.PanelProducto.Controls.Add(this.CBAuto);
            this.PanelProducto.Controls.Add(this.label8);
            this.PanelProducto.Controls.Add(this.panel2);
            this.PanelProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelProducto.Location = new System.Drawing.Point(11, 31);
            this.PanelProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelProducto.Name = "PanelProducto";
            this.PanelProducto.Size = new System.Drawing.Size(519, 222);
            this.PanelProducto.TabIndex = 2;
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(377, 134);
            this.NUDCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(109, 32);
            this.NUDCantidad.TabIndex = 12;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(377, 181);
            this.BTNLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(121, 33);
            this.BTNLimpiar.TabIndex = 5;
            this.BTNLimpiar.Text = "Limpar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.limparDatosVehiculo);
            // 
            // BTNAgregarProducto
            // 
            this.BTNAgregarProducto.Location = new System.Drawing.Point(11, 178);
            this.BTNAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNAgregarProducto.Name = "BTNAgregarProducto";
            this.BTNAgregarProducto.Size = new System.Drawing.Size(115, 43);
            this.BTNAgregarProducto.TabIndex = 4;
            this.BTNAgregarProducto.Text = "Agregar";
            this.BTNAgregarProducto.UseVisualStyleBackColor = true;
            this.BTNAgregarProducto.Click += new System.EventHandler(this.agregarProducto);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(12, 134);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(325, 32);
            this.TBPrecio.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio";
            // 
            // CBAuto
            // 
            this.CBAuto.FormattingEnabled = true;
            this.CBAuto.Location = new System.Drawing.Point(7, 47);
            this.CBAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBAuto.Name = "CBAuto";
            this.CBAuto.Size = new System.Drawing.Size(479, 32);
            this.CBAuto.TabIndex = 9;
            this.CBAuto.SelectedIndexChanged += new System.EventHandler(this.CBAuto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vehiculo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(553, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 155);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producto";
            // 
            // PanelCliente
            // 
            this.PanelCliente.Controls.Add(this.TBEmail);
            this.PanelCliente.Controls.Add(this.TBApellido);
            this.PanelCliente.Controls.Add(this.TBNombre);
            this.PanelCliente.Controls.Add(this.label7);
            this.PanelCliente.Controls.Add(this.label6);
            this.PanelCliente.Controls.Add(this.label5);
            this.PanelCliente.Controls.Add(this.label4);
            this.PanelCliente.Controls.Add(this.CBDni);
            this.PanelCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCliente.Location = new System.Drawing.Point(545, 31);
            this.PanelCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(697, 172);
            this.PanelCliente.TabIndex = 3;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(317, 41);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.ReadOnly = true;
            this.TBEmail.Size = new System.Drawing.Size(364, 32);
            this.TBEmail.TabIndex = 8;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(317, 122);
            this.TBApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.ReadOnly = true;
            this.TBApellido.Size = new System.Drawing.Size(219, 32);
            this.TBApellido.TabIndex = 7;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(4, 122);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(228, 32);
            this.TBNombre.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // CBDni
            // 
            this.CBDni.FormattingEnabled = true;
            this.CBDni.Location = new System.Drawing.Point(5, 39);
            this.CBDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBDni.Name = "CBDni";
            this.CBDni.Size = new System.Drawing.Size(160, 32);
            this.CBDni.TabIndex = 1;
            this.CBDni.SelectedIndexChanged += new System.EventHandler(this.CBDni_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // DGProductosAgregados
            // 
            this.DGProductosAgregados.AllowUserToAddRows = false;
            this.DGProductosAgregados.AllowUserToDeleteRows = false;
            this.DGProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductosAgregados.Location = new System.Drawing.Point(537, 208);
            this.DGProductosAgregados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGProductosAgregados.Name = "DGProductosAgregados";
            this.DGProductosAgregados.ReadOnly = true;
            this.DGProductosAgregados.RowHeadersWidth = 51;
            this.DGProductosAgregados.Size = new System.Drawing.Size(720, 604);
            this.DGProductosAgregados.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 393);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Venta Final";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.LNombreVendedor);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.BTNCancelarVenta);
            this.panel1.Controls.Add(this.BTNFinalizarVenta);
            this.panel1.Controls.Add(this.LTotal);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 363);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(409, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ver todas las ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.mostrarFormVentasTotales);
            // 
            // LNombreVendedor
            // 
            this.LNombreVendedor.AutoSize = true;
            this.LNombreVendedor.Location = new System.Drawing.Point(137, 94);
            this.LNombreVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombreVendedor.Name = "LNombreVendedor";
            this.LNombreVendedor.Size = new System.Drawing.Size(90, 24);
            this.LNombreVendedor.TabIndex = 5;
            this.LNombreVendedor.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 24);
            this.label13.TabIndex = 4;
            this.label13.Text = "Vendedor:";
            // 
            // BTNCancelarVenta
            // 
            this.BTNCancelarVenta.Location = new System.Drawing.Point(260, 172);
            this.BTNCancelarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNCancelarVenta.Name = "BTNCancelarVenta";
            this.BTNCancelarVenta.Size = new System.Drawing.Size(119, 73);
            this.BTNCancelarVenta.TabIndex = 3;
            this.BTNCancelarVenta.Text = "Cancelar Venta";
            this.BTNCancelarVenta.UseVisualStyleBackColor = true;
            this.BTNCancelarVenta.Click += new System.EventHandler(this.cancelarVenta);
            // 
            // BTNFinalizarVenta
            // 
            this.BTNFinalizarVenta.Location = new System.Drawing.Point(15, 172);
            this.BTNFinalizarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNFinalizarVenta.Name = "BTNFinalizarVenta";
            this.BTNFinalizarVenta.Size = new System.Drawing.Size(119, 73);
            this.BTNFinalizarVenta.TabIndex = 2;
            this.BTNFinalizarVenta.Text = "Finalizar Venta";
            this.BTNFinalizarVenta.UseVisualStyleBackColor = true;
            this.BTNFinalizarVenta.Click += new System.EventHandler(this.finalizarVenta);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(165, 33);
            this.LTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(60, 24);
            this.LTotal.TabIndex = 1;
            this.LTotal.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 33);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Precio Final:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 279);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 29);
            this.label14.TabIndex = 7;
            this.label14.Text = "Control";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Elimnar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTNEliminarProducto_Click);
            // 
            // FormAgregarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 814);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DGProductosAgregados);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelProducto);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAgregarVentas";
            this.Text = "AgregarVenta";
            this.Load += new System.EventHandler(this.preCargarDatos);
            this.PanelProducto.ResumeLayout(false);
            this.PanelProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelCliente.ResumeLayout(false);
            this.PanelCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductosAgregados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBDni;
        private System.Windows.Forms.ComboBox CBAuto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNAgregarProducto;
        private System.Windows.Forms.DataGridView DGProductosAgregados;
        private System.Windows.Forms.NumericUpDown NUDCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BTNFinalizarVenta;
        private System.Windows.Forms.Button BTNCancelarVenta;
        private System.Windows.Forms.Label LNombreVendedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}