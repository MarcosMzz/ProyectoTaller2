namespace ProyectoTaller
{
    partial class FormPrincipalVentasSupervisor
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
            this.DGVentasSupervisor = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.BBorrarFiltros = new System.Windows.Forms.Button();
            this.BControlesCruzados = new System.Windows.Forms.Button();
            this.BFiltrar = new System.Windows.Forms.Button();
            this.LVendedor = new System.Windows.Forms.Label();
            this.LFPU = new System.Windows.Forms.Label();
            this.LFPF = new System.Windows.Forms.Label();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.LHasta = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasSupervisor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVentasSupervisor
            // 
            this.DGVentasSupervisor.AllowUserToAddRows = false;
            this.DGVentasSupervisor.AllowUserToDeleteRows = false;
            this.DGVentasSupervisor.AllowUserToResizeColumns = false;
            this.DGVentasSupervisor.AllowUserToResizeRows = false;
            this.DGVentasSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentasSupervisor.Location = new System.Drawing.Point(43, 153);
            this.DGVentasSupervisor.Name = "DGVentasSupervisor";
            this.DGVentasSupervisor.ReadOnly = true;
            this.DGVentasSupervisor.RowHeadersWidth = 51;
            this.DGVentasSupervisor.Size = new System.Drawing.Size(855, 508);
            this.DGVentasSupervisor.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(824, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generar PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BGenerarPDF_Click);
            // 
            // BBorrarFiltros
            // 
            this.BBorrarFiltros.Location = new System.Drawing.Point(559, 122);
            this.BBorrarFiltros.Name = "BBorrarFiltros";
            this.BBorrarFiltros.Size = new System.Drawing.Size(100, 25);
            this.BBorrarFiltros.TabIndex = 3;
            this.BBorrarFiltros.Text = "Borrar Filtros";
            this.BBorrarFiltros.UseVisualStyleBackColor = true;
            this.BBorrarFiltros.Click += new System.EventHandler(this.BBorrarFiltros_Click);
            // 
            // BControlesCruzados
            // 
            this.BControlesCruzados.Location = new System.Drawing.Point(690, 73);
            this.BControlesCruzados.Name = "BControlesCruzados";
            this.BControlesCruzados.Size = new System.Drawing.Size(109, 25);
            this.BControlesCruzados.TabIndex = 4;
            this.BControlesCruzados.Text = "Controles Cruzados";
            this.BControlesCruzados.UseVisualStyleBackColor = true;
            this.BControlesCruzados.Click += new System.EventHandler(this.BControlesCruzados_Click);
            // 
            // BFiltrar
            // 
            this.BFiltrar.Location = new System.Drawing.Point(559, 73);
            this.BFiltrar.Name = "BFiltrar";
            this.BFiltrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BFiltrar.Size = new System.Drawing.Size(100, 25);
            this.BFiltrar.TabIndex = 18;
            this.BFiltrar.Text = "Filtrar";
            this.BFiltrar.UseVisualStyleBackColor = true;
            this.BFiltrar.Click += new System.EventHandler(this.BFiltrar_Click);
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Location = new System.Drawing.Point(281, 103);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(57, 13);
            this.LVendedor.TabIndex = 17;
            this.LVendedor.Text = "Vendedor:";
            // 
            // LFPU
            // 
            this.LFPU.AutoSize = true;
            this.LFPU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFPU.Location = new System.Drawing.Point(364, 58);
            this.LFPU.Name = "LFPU";
            this.LFPU.Size = new System.Drawing.Size(112, 14);
            this.LFPU.TabIndex = 16;
            this.LFPU.Text = "Filtro Por Usuario";
            // 
            // LFPF
            // 
            this.LFPF.AutoSize = true;
            this.LFPF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFPF.Location = new System.Drawing.Point(96, 58);
            this.LFPF.Name = "LFPF";
            this.LFPF.Size = new System.Drawing.Size(101, 14);
            this.LFPF.TabIndex = 15;
            this.LFPF.Text = "Filtro Por Fecha";
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(343, 100);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(200, 21);
            this.comboUsuarios.TabIndex = 14;
            // 
            // DTPHasta
            // 
            this.DTPHasta.Location = new System.Drawing.Point(61, 122);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(200, 21);
            this.DTPHasta.TabIndex = 13;
            // 
            // DTPDesde
            // 
            this.DTPDesde.Location = new System.Drawing.Point(61, 78);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(200, 21);
            this.DTPDesde.TabIndex = 12;
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(19, 128);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(39, 13);
            this.LHasta.TabIndex = 11;
            this.LHasta.Text = "Hasta:";
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(19, 84);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(41, 13);
            this.LDesde.TabIndex = 10;
            this.LDesde.Text = "Desde:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Descargar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BDescargarFactura);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Control de Ventas";
            // 
            // FormPrincipalVentasSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BFiltrar);
            this.Controls.Add(this.LVendedor);
            this.Controls.Add(this.LFPU);
            this.Controls.Add(this.LFPF);
            this.Controls.Add(this.comboUsuarios);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.BControlesCruzados);
            this.Controls.Add(this.BBorrarFiltros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGVentasSupervisor);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPrincipalVentasSupervisor";
            this.Text = "Ventas Supervisor";
            this.Load += new System.EventHandler(this.cargarDatosVentaSup);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasSupervisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVentasSupervisor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BBorrarFiltros;
        private System.Windows.Forms.Button BControlesCruzados;
        private System.Windows.Forms.Button BFiltrar;
        private System.Windows.Forms.Label LVendedor;
        private System.Windows.Forms.Label LFPU;
        private System.Windows.Forms.Label LFPF;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}