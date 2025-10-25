namespace ProyectoTaller
{
    partial class FormPrincipalAutos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVehiculos = new System.Windows.Forms.DataGridView();
            this.BTNAgregarAuto = new System.Windows.Forms.Button();
            this.BTNModificarAuto = new System.Windows.Forms.Button();
            this.BTNDarDeBajaAuto = new System.Windows.Forms.Button();
            this.BTNActivarAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVehiculos
            // 
            this.DGVehiculos.AllowUserToAddRows = false;
            this.DGVehiculos.AllowUserToDeleteRows = false;
            this.DGVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVehiculos.Location = new System.Drawing.Point(0, 123);
            this.DGVehiculos.Name = "DGVehiculos";
            this.DGVehiculos.ReadOnly = true;
            this.DGVehiculos.RowHeadersWidth = 51;
            this.DGVehiculos.Size = new System.Drawing.Size(953, 556);
            this.DGVehiculos.TabIndex = 5;
            // 
            // BTNAgregarAuto
            // 
            this.BTNAgregarAuto.Location = new System.Drawing.Point(198, 26);
            this.BTNAgregarAuto.Name = "BTNAgregarAuto";
            this.BTNAgregarAuto.Size = new System.Drawing.Size(102, 62);
            this.BTNAgregarAuto.TabIndex = 6;
            this.BTNAgregarAuto.Text = "Agregar";
            this.BTNAgregarAuto.UseVisualStyleBackColor = true;
            this.BTNAgregarAuto.Click += new System.EventHandler(this.abrirFormAgregarAutos);
            // 
            // BTNModificarAuto
            // 
            this.BTNModificarAuto.Location = new System.Drawing.Point(332, 26);
            this.BTNModificarAuto.Name = "BTNModificarAuto";
            this.BTNModificarAuto.Size = new System.Drawing.Size(102, 62);
            this.BTNModificarAuto.TabIndex = 7;
            this.BTNModificarAuto.Text = "Modificar";
            this.BTNModificarAuto.UseVisualStyleBackColor = true;
            this.BTNModificarAuto.Click += new System.EventHandler(this.abrirFormModificarAutos);
            // 
            // BTNDarDeBajaAuto
            // 
            this.BTNDarDeBajaAuto.Location = new System.Drawing.Point(479, 26);
            this.BTNDarDeBajaAuto.Name = "BTNDarDeBajaAuto";
            this.BTNDarDeBajaAuto.Size = new System.Drawing.Size(102, 62);
            this.BTNDarDeBajaAuto.TabIndex = 8;
            this.BTNDarDeBajaAuto.Text = "Dar de Baja";
            this.BTNDarDeBajaAuto.UseVisualStyleBackColor = true;
            this.BTNDarDeBajaAuto.Click += new System.EventHandler(this.darDeBajaAutos);
            // 
            // BTNActivarAuto
            // 
            this.BTNActivarAuto.Location = new System.Drawing.Point(626, 26);
            this.BTNActivarAuto.Name = "BTNActivarAuto";
            this.BTNActivarAuto.Size = new System.Drawing.Size(102, 62);
            this.BTNActivarAuto.TabIndex = 9;
            this.BTNActivarAuto.Text = "Dar de Alta";
            this.BTNActivarAuto.UseVisualStyleBackColor = true;
            this.BTNActivarAuto.Click += new System.EventHandler(this.darDeAltaAutos);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Control de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vehiculos";
            // 
            // FormPrincipalAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(954, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNActivarAuto);
            this.Controls.Add(this.BTNDarDeBajaAuto);
            this.Controls.Add(this.BTNModificarAuto);
            this.Controls.Add(this.BTNAgregarAuto);
            this.Controls.Add(this.DGVehiculos);
            this.Name = "FormPrincipalAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de Autos";
            this.Load += new System.EventHandler(this.cargarAutos);
            ((System.ComponentModel.ISupportInitialize)(this.DGVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVehiculos;
        private System.Windows.Forms.Button BTNAgregarAuto;
        private System.Windows.Forms.Button BTNModificarAuto;
        private System.Windows.Forms.Button BTNDarDeBajaAuto;
        private System.Windows.Forms.Button BTNActivarAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

