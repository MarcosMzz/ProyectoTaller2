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
            this.BFiltrarVentas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BBorrarFiltros = new System.Windows.Forms.Button();
            this.BControlesCruzados = new System.Windows.Forms.Button();
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
            this.DGVentasSupervisor.Location = new System.Drawing.Point(0, 118);
            this.DGVentasSupervisor.Name = "DGVentasSupervisor";
            this.DGVentasSupervisor.ReadOnly = true;
            this.DGVentasSupervisor.RowHeadersWidth = 51;
            this.DGVentasSupervisor.Size = new System.Drawing.Size(944, 546);
            this.DGVentasSupervisor.TabIndex = 0;
            // 
            // BFiltrarVentas
            // 
            this.BFiltrarVentas.Location = new System.Drawing.Point(12, 12);
            this.BFiltrarVentas.Name = "BFiltrarVentas";
            this.BFiltrarVentas.Size = new System.Drawing.Size(107, 77);
            this.BFiltrarVentas.TabIndex = 1;
            this.BFiltrarVentas.Text = "Filtrar";
            this.BFiltrarVentas.UseVisualStyleBackColor = true;
            this.BFiltrarVentas.Click += new System.EventHandler(this.BFiltrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Generar PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BBorrarFiltros
            // 
            this.BBorrarFiltros.Location = new System.Drawing.Point(134, 12);
            this.BBorrarFiltros.Name = "BBorrarFiltros";
            this.BBorrarFiltros.Size = new System.Drawing.Size(107, 77);
            this.BBorrarFiltros.TabIndex = 3;
            this.BBorrarFiltros.Text = "Borrar Filtros";
            this.BBorrarFiltros.UseVisualStyleBackColor = true;
            this.BBorrarFiltros.Click += new System.EventHandler(this.BBorrarFiltros_Click);
            // 
            // BControlesCruzados
            // 
            this.BControlesCruzados.Location = new System.Drawing.Point(703, 12);
            this.BControlesCruzados.Name = "BControlesCruzados";
            this.BControlesCruzados.Size = new System.Drawing.Size(107, 77);
            this.BControlesCruzados.TabIndex = 4;
            this.BControlesCruzados.Text = "Controles Cruzados";
            this.BControlesCruzados.UseVisualStyleBackColor = true;
            this.BControlesCruzados.Click += new System.EventHandler(this.BControlesCruzados_Click);
            // 
            // FormPrincipalVentasSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.BControlesCruzados);
            this.Controls.Add(this.BBorrarFiltros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BFiltrarVentas);
            this.Controls.Add(this.DGVentasSupervisor);
            this.Name = "FormPrincipalVentasSupervisor";
            this.Text = "Ventas Supervisor";
            this.Load += new System.EventHandler(this.cargarDatosVentaSup);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasSupervisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVentasSupervisor;
        private System.Windows.Forms.Button BFiltrarVentas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BBorrarFiltros;
        private System.Windows.Forms.Button BControlesCruzados;
    }
}