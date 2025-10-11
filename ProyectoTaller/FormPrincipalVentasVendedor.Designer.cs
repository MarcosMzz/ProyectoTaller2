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
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVentasVendedor
            // 
            this.DGVentasVendedor.AllowUserToDeleteRows = false;
            this.DGVentasVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentasVendedor.Location = new System.Drawing.Point(1, 134);
            this.DGVentasVendedor.Name = "DGVentasVendedor";
            this.DGVentasVendedor.ReadOnly = true;
            this.DGVentasVendedor.RowHeadersWidth = 51;
            this.DGVentasVendedor.Size = new System.Drawing.Size(943, 529);
            this.DGVentasVendedor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.abrirFormAgregarVentas);
            // 
            // FormPrincipalVentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVentasVendedor);
            this.Name = "FormPrincipalVentasVendedor";
            this.Text = "Ventas Vendedor";
            this.Load += new System.EventHandler(this.cargarVentasVendedor);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVentasVendedor;
        private System.Windows.Forms.Button button1;
    }
}