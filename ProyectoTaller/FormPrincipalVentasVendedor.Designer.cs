namespace ProyectoTaller
{
    partial class FormPrincipalVentasVendedor
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
            this.DGVentasVendedor = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BGenerarPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVentasVendedor
            // 
            this.DGVentasVendedor.AllowUserToAddRows = false;
            this.DGVentasVendedor.AllowUserToDeleteRows = false;
            this.DGVentasVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentasVendedor.Location = new System.Drawing.Point(94, 86);
            this.DGVentasVendedor.Name = "DGVentasVendedor";
            this.DGVentasVendedor.ReadOnly = true;
            this.DGVentasVendedor.RowHeadersWidth = 51;
            this.DGVentasVendedor.Size = new System.Drawing.Size(755, 567);
            this.DGVentasVendedor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.abrirFormAgregarVentas);
            // 
            // BGenerarPDF
            // 
            this.BGenerarPDF.Location = new System.Drawing.Point(636, 55);
            this.BGenerarPDF.Name = "BGenerarPDF";
            this.BGenerarPDF.Size = new System.Drawing.Size(85, 25);
            this.BGenerarPDF.TabIndex = 2;
            this.BGenerarPDF.Text = "Generar PDF";
            this.BGenerarPDF.UseVisualStyleBackColor = true;
            this.BGenerarPDF.Click += new System.EventHandler(this.BGenerarPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Control de Ventas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.cargarVentasVendedor);
            // 
            // FormPrincipalVentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGenerarPDF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVentasVendedor);
            this.Name = "FormPrincipalVentasVendedor";
            this.Text = "Ventas Vendedor";
            this.Load += new System.EventHandler(this.cargarVentasVendedor);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVentasVendedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BGenerarPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}