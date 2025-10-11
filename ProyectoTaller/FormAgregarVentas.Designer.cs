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
            this.LNombreVendedor = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BTNCancelarVenta = new System.Windows.Forms.Button();
            this.BTNFinalizarVenta = new System.Windows.Forms.Button();
            this.LTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
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
            this.PanelProducto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelProducto.Location = new System.Drawing.Point(8, 25);
            this.PanelProducto.Name = "PanelProducto";
            this.PanelProducto.Size = new System.Drawing.Size(389, 180);
            this.PanelProducto.TabIndex = 2;
            // 
            // NUDCantidad
            // 
            this.NUDCantidad.Location = new System.Drawing.Point(283, 109);
            this.NUDCantidad.Name = "NUDCantidad";
            this.NUDCantidad.Size = new System.Drawing.Size(82, 26);
            this.NUDCantidad.TabIndex = 12;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(283, 147);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(91, 27);
            this.BTNLimpiar.TabIndex = 5;
            this.BTNLimpiar.Text = "Limpar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.limparDatosVehiculo);
            // 
            // BTNAgregarProducto
            // 
            this.BTNAgregarProducto.Location = new System.Drawing.Point(8, 145);
            this.BTNAgregarProducto.Name = "BTNAgregarProducto";
            this.BTNAgregarProducto.Size = new System.Drawing.Size(85, 26);
            this.BTNAgregarProducto.TabIndex = 4;
            this.BTNAgregarProducto.Text = "Agregar";
            this.BTNAgregarProducto.UseVisualStyleBackColor = true;
            this.BTNAgregarProducto.Click += new System.EventHandler(this.agregarProducto);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(9, 109);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(245, 26);
            this.TBPrecio.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio";
            // 
            // CBAuto
            // 
            this.CBAuto.FormattingEnabled = true;
            this.CBAuto.Location = new System.Drawing.Point(5, 38);
            this.CBAuto.Name = "CBAuto";
            this.CBAuto.Size = new System.Drawing.Size(360, 27);
            this.CBAuto.TabIndex = 9;
            this.CBAuto.SelectedIndexChanged += new System.EventHandler(this.CBAuto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vehiculo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(415, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 126);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
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
            this.PanelCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCliente.Location = new System.Drawing.Point(409, 25);
            this.PanelCliente.Name = "PanelCliente";
            this.PanelCliente.Size = new System.Drawing.Size(523, 140);
            this.PanelCliente.TabIndex = 3;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(238, 33);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.ReadOnly = true;
            this.TBEmail.Size = new System.Drawing.Size(274, 27);
            this.TBEmail.TabIndex = 8;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(238, 99);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.ReadOnly = true;
            this.TBApellido.Size = new System.Drawing.Size(165, 27);
            this.TBApellido.TabIndex = 7;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(3, 99);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(172, 27);
            this.TBNombre.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // CBDni
            // 
            this.CBDni.FormattingEnabled = true;
            this.CBDni.Location = new System.Drawing.Point(4, 32);
            this.CBDni.Name = "CBDni";
            this.CBDni.Size = new System.Drawing.Size(121, 28);
            this.CBDni.TabIndex = 1;
            this.CBDni.SelectedIndexChanged += new System.EventHandler(this.CBDni_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // DGProductosAgregados
            // 
            this.DGProductosAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductosAgregados.Location = new System.Drawing.Point(403, 169);
            this.DGProductosAgregados.Name = "DGProductosAgregados";
            this.DGProductosAgregados.Size = new System.Drawing.Size(540, 491);
            this.DGProductosAgregados.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
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
            this.panel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 295);
            this.panel1.TabIndex = 6;
            // 
            // LNombreVendedor
            // 
            this.LNombreVendedor.AutoSize = true;
            this.LNombreVendedor.Location = new System.Drawing.Point(103, 76);
            this.LNombreVendedor.Name = "LNombreVendedor";
            this.LNombreVendedor.Size = new System.Drawing.Size(73, 19);
            this.LNombreVendedor.TabIndex = 5;
            this.LNombreVendedor.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Vendedor:";
            // 
            // BTNCancelarVenta
            // 
            this.BTNCancelarVenta.Location = new System.Drawing.Point(195, 140);
            this.BTNCancelarVenta.Name = "BTNCancelarVenta";
            this.BTNCancelarVenta.Size = new System.Drawing.Size(89, 59);
            this.BTNCancelarVenta.TabIndex = 3;
            this.BTNCancelarVenta.Text = "Cancelar Venta";
            this.BTNCancelarVenta.UseVisualStyleBackColor = true;
            this.BTNCancelarVenta.Click += new System.EventHandler(this.cancelarVenta);
            // 
            // BTNFinalizarVenta
            // 
            this.BTNFinalizarVenta.Location = new System.Drawing.Point(11, 140);
            this.BTNFinalizarVenta.Name = "BTNFinalizarVenta";
            this.BTNFinalizarVenta.Size = new System.Drawing.Size(89, 59);
            this.BTNFinalizarVenta.TabIndex = 2;
            this.BTNFinalizarVenta.Text = "Finalizar Venta";
            this.BTNFinalizarVenta.UseVisualStyleBackColor = true;
            this.BTNFinalizarVenta.Click += new System.EventHandler(this.finalizarVenta);
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(124, 27);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(50, 19);
            this.LTotal.TabIndex = 1;
            this.LTotal.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Precio Final:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Control";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Elimnar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BTNEliminarProducto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ver todas las ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.mostrarFormVentasTotales);
            // 
            // FormAgregarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DGProductosAgregados);
            this.Controls.Add(this.PanelCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelProducto);
            this.Controls.Add(this.label2);
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