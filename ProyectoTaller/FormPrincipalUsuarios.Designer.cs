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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGUusarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGUusarios
            // 
            this.DGUusarios.AllowUserToAddRows = false;
            this.DGUusarios.AllowUserToDeleteRows = false;
            this.DGUusarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUusarios.Location = new System.Drawing.Point(90, 96);
            this.DGUusarios.Name = "DGUusarios";
            this.DGUusarios.ReadOnly = true;
            this.DGUusarios.RowHeadersWidth = 51;
            this.DGUusarios.Size = new System.Drawing.Size(754, 553);
            this.DGUusarios.TabIndex = 0;
            // 
            // BTNUsuarioAgregar
            // 
            this.BTNUsuarioAgregar.Location = new System.Drawing.Point(14, 18);
            this.BTNUsuarioAgregar.Name = "BTNUsuarioAgregar";
            this.BTNUsuarioAgregar.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioAgregar.TabIndex = 1;
            this.BTNUsuarioAgregar.Text = "Agregar";
            this.BTNUsuarioAgregar.UseVisualStyleBackColor = true;
            this.BTNUsuarioAgregar.Click += new System.EventHandler(this.AbrirFormAgregarCliente);
            // 
            // BTNUsuarioModificar
            // 
            this.BTNUsuarioModificar.Location = new System.Drawing.Point(156, 18);
            this.BTNUsuarioModificar.Name = "BTNUsuarioModificar";
            this.BTNUsuarioModificar.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioModificar.TabIndex = 2;
            this.BTNUsuarioModificar.Text = "Modificar";
            this.BTNUsuarioModificar.UseVisualStyleBackColor = true;
            this.BTNUsuarioModificar.Click += new System.EventHandler(this.abrirFormModificarUsuarios);
            // 
            // BTNUsuarioBaja
            // 
            this.BTNUsuarioBaja.Location = new System.Drawing.Point(291, 18);
            this.BTNUsuarioBaja.Name = "BTNUsuarioBaja";
            this.BTNUsuarioBaja.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioBaja.TabIndex = 3;
            this.BTNUsuarioBaja.Text = "Dar de Baja";
            this.BTNUsuarioBaja.UseVisualStyleBackColor = true;
            this.BTNUsuarioBaja.Click += new System.EventHandler(this.DarDeBajaUsuarios);
            // 
            // BTNUsuarioActivar
            // 
            this.BTNUsuarioActivar.Location = new System.Drawing.Point(424, 18);
            this.BTNUsuarioActivar.Name = "BTNUsuarioActivar";
            this.BTNUsuarioActivar.Size = new System.Drawing.Size(99, 61);
            this.BTNUsuarioActivar.TabIndex = 4;
            this.BTNUsuarioActivar.Text = "Activar";
            this.BTNUsuarioActivar.UseVisualStyleBackColor = true;
            this.BTNUsuarioActivar.Click += new System.EventHandler(this.DarDeAltaUsuarios);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNUsuarioAgregar);
            this.panel1.Controls.Add(this.BTNUsuarioModificar);
            this.panel1.Controls.Add(this.BTNUsuarioActivar);
            this.panel1.Controls.Add(this.BTNUsuarioBaja);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(189, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 88);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuarios";
            // 
            // FormPrincipalUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGUusarios);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipalUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.inicializarTablaUsuarios);
            ((System.ComponentModel.ISupportInitialize)(this.DGUusarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGUusarios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTNUsuarioAgregar;
        private System.Windows.Forms.Button BTNUsuarioModificar;
        private System.Windows.Forms.Button BTNUsuarioBaja;
        private System.Windows.Forms.Button BTNUsuarioActivar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}