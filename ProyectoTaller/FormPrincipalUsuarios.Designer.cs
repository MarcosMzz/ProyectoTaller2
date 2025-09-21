namespace ProyectoTaller
{
    partial class FormPrincipalUsuarios
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
            this.DGUusarios = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTNUsuarioAgregar = new System.Windows.Forms.Button();
            this.BTNUsuarioModificar = new System.Windows.Forms.Button();
            this.BTNUsuarioBaja = new System.Windows.Forms.Button();
            this.BTNUsuarioActivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGUusarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGUusarios
            // 
            this.DGUusarios.AllowUserToDeleteRows = false;
            this.DGUusarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUusarios.Location = new System.Drawing.Point(90, 96);
            this.DGUusarios.Name = "DGUusarios";
            this.DGUusarios.ReadOnly = true;
            this.DGUusarios.Size = new System.Drawing.Size(754, 553);
            this.DGUusarios.TabIndex = 0;
            // 
            // BTNUsuarioAgregar
            // 
            this.BTNUsuarioAgregar.Location = new System.Drawing.Point(210, 31);
            this.BTNUsuarioAgregar.Name = "BTNUsuarioAgregar";
            this.BTNUsuarioAgregar.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioAgregar.TabIndex = 1;
            this.BTNUsuarioAgregar.Text = "Agregar Usuario";
            this.BTNUsuarioAgregar.UseVisualStyleBackColor = true;
            this.BTNUsuarioAgregar.Click += new System.EventHandler(this.AbrirFormAgregarCliente);
            // 
            // BTNUsuarioModificar
            // 
            this.BTNUsuarioModificar.Location = new System.Drawing.Point(342, 31);
            this.BTNUsuarioModificar.Name = "BTNUsuarioModificar";
            this.BTNUsuarioModificar.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioModificar.TabIndex = 2;
            this.BTNUsuarioModificar.Text = "Modificar Usuario";
            this.BTNUsuarioModificar.UseVisualStyleBackColor = true;
            // 
            // BTNUsuarioBaja
            // 
            this.BTNUsuarioBaja.Location = new System.Drawing.Point(478, 31);
            this.BTNUsuarioBaja.Name = "BTNUsuarioBaja";
            this.BTNUsuarioBaja.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioBaja.TabIndex = 3;
            this.BTNUsuarioBaja.Text = "Dar de Baja Usuario";
            this.BTNUsuarioBaja.UseVisualStyleBackColor = true;
            // 
            // BTNUsuarioActivar
            // 
            this.BTNUsuarioActivar.Location = new System.Drawing.Point(602, 31);
            this.BTNUsuarioActivar.Name = "BTNUsuarioActivar";
            this.BTNUsuarioActivar.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioActivar.TabIndex = 4;
            this.BTNUsuarioActivar.Text = "Activar Usuario";
            this.BTNUsuarioActivar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipalUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.BTNUsuarioActivar);
            this.Controls.Add(this.BTNUsuarioBaja);
            this.Controls.Add(this.BTNUsuarioModificar);
            this.Controls.Add(this.BTNUsuarioAgregar);
            this.Controls.Add(this.DGUusarios);
            this.Name = "FormPrincipalUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.inicializarTablaUsuarios);
            ((System.ComponentModel.ISupportInitialize)(this.DGUusarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGUusarios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTNUsuarioAgregar;
        private System.Windows.Forms.Button BTNUsuarioModificar;
        private System.Windows.Forms.Button BTNUsuarioBaja;
        private System.Windows.Forms.Button BTNUsuarioActivar;
    }
}