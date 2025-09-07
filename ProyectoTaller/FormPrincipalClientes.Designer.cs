namespace ProyectoTaller
{
    partial class FormPrincipalClientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.ID_ClienteColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimientoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivoColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AbrirFormularioAgregarClientes);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dar de Baja Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bajaCliente);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.modificarCliente);
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ClienteColumna,
            this.NombreColumna,
            this.ApellidoColumna,
            this.DNIColumna,
            this.EmailColumna,
            this.TelefonoColumna,
            this.DireccionColumna,
            this.FechaDeNacimientoColumna,
            this.ActivoColumna});
            this.DGVClientes.Location = new System.Drawing.Point(2, 87);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.Size = new System.Drawing.Size(944, 563);
            this.DGVClientes.TabIndex = 3;
            // 
            // ID_ClienteColumna
            // 
            this.ID_ClienteColumna.HeaderText = "ID_Cliente";
            this.ID_ClienteColumna.Name = "ID_ClienteColumna";
            // 
            // NombreColumna
            // 
            this.NombreColumna.HeaderText = "Nombre";
            this.NombreColumna.Name = "NombreColumna";
            // 
            // ApellidoColumna
            // 
            this.ApellidoColumna.HeaderText = "Apellido";
            this.ApellidoColumna.Name = "ApellidoColumna";
            // 
            // DNIColumna
            // 
            this.DNIColumna.HeaderText = "DNI";
            this.DNIColumna.Name = "DNIColumna";
            // 
            // EmailColumna
            // 
            this.EmailColumna.HeaderText = "Email";
            this.EmailColumna.Name = "EmailColumna";
            // 
            // TelefonoColumna
            // 
            this.TelefonoColumna.HeaderText = "Telefono";
            this.TelefonoColumna.Name = "TelefonoColumna";
            // 
            // DireccionColumna
            // 
            this.DireccionColumna.HeaderText = "Direccion";
            this.DireccionColumna.Name = "DireccionColumna";
            // 
            // FechaDeNacimientoColumna
            // 
            this.FechaDeNacimientoColumna.HeaderText = "Fecha de Nacimiento";
            this.FechaDeNacimientoColumna.Name = "FechaDeNacimientoColumna";
            // 
            // ActivoColumna
            // 
            this.ActivoColumna.HeaderText = "Activo";
            this.ActivoColumna.Name = "ActivoColumna";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(630, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "Activar Cliente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.activarCliente);
            // 
            // FormPrincipalClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 666);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormPrincipalClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ClienteColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimientoColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivoColumna;
        private System.Windows.Forms.Button button4;
    }
}