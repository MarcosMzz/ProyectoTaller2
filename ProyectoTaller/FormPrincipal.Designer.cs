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
            this.MSBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBNombre = new System.Windows.Forms.Label();
            this.LBRol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBApellido = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.MSClientes.Size = new System.Drawing.Size(113, 25);
            this.MSClientes.Text = "Clientes";
            this.MSClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // MSVehiculos
            // 
            this.MSVehiculos.Name = "MSVehiculos";
            this.MSVehiculos.Size = new System.Drawing.Size(113, 25);
            this.MSVehiculos.Text = "Vehiculos";
            this.MSVehiculos.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // MSVentas
            // 
            this.MSVentas.Name = "MSVentas";
            this.MSVentas.Size = new System.Drawing.Size(113, 25);
            this.MSVentas.Text = "Ventas";
            this.MSVentas.Click += new System.EventHandler(this.abrirVentas);
            // 
            // MSUsuarios
            // 
            this.MSUsuarios.Name = "MSUsuarios";
            this.MSUsuarios.Size = new System.Drawing.Size(113, 25);
            this.MSUsuarios.Text = "Usuarios";
            this.MSUsuarios.Click += new System.EventHandler(this.abrirUsuarios);
            // 
            // MSBackup
            // 
            this.MSBackup.Name = "MSBackup";
            this.MSBackup.Size = new System.Drawing.Size(115, 25);
            this.MSBackup.Text = "Hacer BackUp";
            this.MSBackup.Visible = false;
            this.MSBackup.Click += new System.EventHandler(this.abrirFormBackUp);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(113, 25);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesion);
            // 
            // LBNombre
            // 
            this.LBNombre.AutoSize = true;
            this.LBNombre.Location = new System.Drawing.Point(-3, 99);
            this.LBNombre.Name = "LBNombre";
            this.LBNombre.Size = new System.Drawing.Size(132, 21);
            this.LBNombre.TabIndex = 4;
            this.LBNombre.Text = "NombreUsuario";
            // 
            // LBRol
            // 
            this.LBRol.AutoSize = true;
            this.LBRol.Location = new System.Drawing.Point(-3, 148);
            this.LBRol.Name = "LBRol";
            this.LBRol.Size = new System.Drawing.Size(35, 21);
            this.LBRol.TabIndex = 5;
            this.LBRol.Text = "Rol";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBApellido);
            this.panel1.Controls.Add(this.LBRol);
            this.panel1.Controls.Add(this.LBNombre);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 228);
            this.panel1.TabIndex = 6;
            // 
            // LBApellido
            // 
            this.LBApellido.AutoSize = true;
            this.LBApellido.Location = new System.Drawing.Point(-3, 120);
            this.LBApellido.Name = "LBApellido";
            this.LBApellido.Size = new System.Drawing.Size(134, 21);
            this.LBApellido.TabIndex = 6;
            this.LBApellido.Text = "ApellidoUsuario";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label LBNombre;
        private System.Windows.Forms.Label LBRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBApellido;
    }
}