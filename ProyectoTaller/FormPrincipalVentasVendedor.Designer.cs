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
            this.DGVentasVendedor.Location = new System.Drawing.Point(1, 165);
            this.DGVentasVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVentasVendedor.Name = "DGVentasVendedor";
            this.DGVentasVendedor.ReadOnly = true;
            this.DGVentasVendedor.RowHeadersWidth = 51;
            this.DGVentasVendedor.Size = new System.Drawing.Size(1257, 651);
            this.DGVentasVendedor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 96);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Ventas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPrincipalVentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 814);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVentasVendedor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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