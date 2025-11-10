namespace ProyectoTaller
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MSClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.MSVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MSUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSClientes,
            this.MSVehiculos,
            this.MSVentas,
            this.MSUsuarios,
            this.MSBackup,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.menuStrip1.Size = new System.Drawing.Size(118, 681);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menu";
            // 
            // MSClientes
            // 
            this.MSClientes.Name = "MSClientes";
            this.MSClientes.Size = new System.Drawing.Size(117, 25);
            this.MSClientes.Text = "Clientes";
            this.MSClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MSVehiculos
            // 
            this.MSVehiculos.Name = "MSVehiculos";
            this.MSVehiculos.Size = new System.Drawing.Size(117, 25);
            this.MSVehiculos.Text = "Vehiculos";
            this.MSVehiculos.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // MSVentas
            // 
            this.MSVentas.Name = "MSVentas";
            this.MSVentas.Size = new System.Drawing.Size(117, 25);
            this.MSVentas.Text = "Ventas";
            this.MSVentas.Click += new System.EventHandler(this.abrirVentas);
            // 
            // MSUsuarios
            // 
            this.MSUsuarios.Name = "MSUsuarios";
            this.MSUsuarios.Size = new System.Drawing.Size(117, 25);
            this.MSUsuarios.Text = "Usuarios";
            this.MSUsuarios.Click += new System.EventHandler(this.abrirUsuarios);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesion);
            // 
            // MSBackup
            // 
            this.MSBackup.Name = "MSBackup";
            this.MSBackup.Size = new System.Drawing.Size(117, 25);
            this.MSBackup.Text = "Hacer BackUp";
            this.MSBackup.Visible = false;
            this.MSBackup.Click += new System.EventHandler(this.abrirFormBackUp);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MSClientes;
        private System.Windows.Forms.ToolStripMenuItem MSVehiculos;
        private System.Windows.Forms.ToolStripMenuItem MSVentas;
        private System.Windows.Forms.ToolStripMenuItem MSUsuarios;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSBackup;
    }
}