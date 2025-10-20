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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasSupervisor)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVentasSupervisor
            // 
            this.DGVentasSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentasSupervisor.Location = new System.Drawing.Point(0, 118);
            this.DGVentasSupervisor.Name = "DGVentasSupervisor";
            this.DGVentasSupervisor.RowHeadersWidth = 51;
            this.DGVentasSupervisor.Size = new System.Drawing.Size(944, 546);
            this.DGVentasSupervisor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtrar Por usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "Graficar Ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPrincipalVentasSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVentasSupervisor);
            this.Name = "FormPrincipalVentasSupervisor";
            this.Text = "Ventas Supervisor";
            this.Load += new System.EventHandler(this.cargarDatosVentaSup);
            ((System.ComponentModel.ISupportInitialize)(this.DGVentasSupervisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVentasSupervisor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}