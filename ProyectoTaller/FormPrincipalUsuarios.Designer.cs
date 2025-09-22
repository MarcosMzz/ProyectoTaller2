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
            this.DGUusarios.Location = new System.Drawing.Point(120, 118);
            this.DGUusarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGUusarios.Name = "DGUusarios";
            this.DGUusarios.ReadOnly = true;
            this.DGUusarios.RowHeadersWidth = 51;
            this.DGUusarios.Size = new System.Drawing.Size(1005, 681);
            this.DGUusarios.TabIndex = 0;
            // 
            // BTNUsuarioAgregar
            // 
            this.BTNUsuarioAgregar.Location = new System.Drawing.Point(280, 38);
            this.BTNUsuarioAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNUsuarioAgregar.Name = "BTNUsuarioAgregar";
            this.BTNUsuarioAgregar.Size = new System.Drawing.Size(132, 75);
            this.BTNUsuarioAgregar.TabIndex = 1;
            this.BTNUsuarioAgregar.Text = "Agregar Usuario";
            this.BTNUsuarioAgregar.UseVisualStyleBackColor = true;
            this.BTNUsuarioAgregar.Click += new System.EventHandler(this.AbrirFormAgregarCliente);
            // 
            // BTNUsuarioModificar
            // 
            this.BTNUsuarioModificar.Location = new System.Drawing.Point(456, 38);
            this.BTNUsuarioModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNUsuarioModificar.Name = "BTNUsuarioModificar";
            this.BTNUsuarioModificar.Size = new System.Drawing.Size(132, 75);
            this.BTNUsuarioModificar.TabIndex = 2;
            this.BTNUsuarioModificar.Text = "Modificar Usuario";
            this.BTNUsuarioModificar.UseVisualStyleBackColor = true;
            this.BTNUsuarioModificar.Click += new System.EventHandler(this.abrirFormModificarUsuarios);
            // 
            // BTNUsuarioBaja
            // 
            this.BTNUsuarioBaja.Location = new System.Drawing.Point(637, 38);
            this.BTNUsuarioBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNUsuarioBaja.Name = "BTNUsuarioBaja";
            this.BTNUsuarioBaja.Size = new System.Drawing.Size(132, 75);
            this.BTNUsuarioBaja.TabIndex = 3;
            this.BTNUsuarioBaja.Text = "Dar de Baja Usuario";
            this.BTNUsuarioBaja.UseVisualStyleBackColor = true;
            // 
            // BTNUsuarioActivar
            // 
            this.BTNUsuarioActivar.Location = new System.Drawing.Point(803, 38);
            this.BTNUsuarioActivar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNUsuarioActivar.Name = "BTNUsuarioActivar";
            this.BTNUsuarioActivar.Size = new System.Drawing.Size(132, 75);
            this.BTNUsuarioActivar.TabIndex = 4;
            this.BTNUsuarioActivar.Text = "Activar Usuario";
            this.BTNUsuarioActivar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipalUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 814);
            this.Controls.Add(this.BTNUsuarioActivar);
            this.Controls.Add(this.BTNUsuarioBaja);
            this.Controls.Add(this.BTNUsuarioModificar);
            this.Controls.Add(this.BTNUsuarioAgregar);
            this.Controls.Add(this.DGUusarios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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