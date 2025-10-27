namespace ProyectoTaller
{
    partial class FormFiltrarVentasSupervisor
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
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.DTPDesde = new System.Windows.Forms.DateTimePicker();
            this.DTPHasta = new System.Windows.Forms.DateTimePicker();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.LFPF = new System.Windows.Forms.Label();
            this.LFPU = new System.Windows.Forms.Label();
            this.LVendedor = new System.Windows.Forms.Label();
            this.BEnviar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(21, 65);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(41, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde:";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(24, 115);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(38, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta:";
            // 
            // DTPDesde
            // 
            this.DTPDesde.Location = new System.Drawing.Point(72, 65);
            this.DTPDesde.Name = "DTPDesde";
            this.DTPDesde.Size = new System.Drawing.Size(200, 20);
            this.DTPDesde.TabIndex = 2;
            // 
            // DTPHasta
            // 
            this.DTPHasta.Location = new System.Drawing.Point(72, 115);
            this.DTPHasta.Name = "DTPHasta";
            this.DTPHasta.Size = new System.Drawing.Size(200, 20);
            this.DTPHasta.TabIndex = 3;
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(72, 209);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(200, 21);
            this.comboUsuarios.TabIndex = 4;
            // 
            // LFPF
            // 
            this.LFPF.AutoSize = true;
            this.LFPF.Location = new System.Drawing.Point(104, 20);
            this.LFPF.Name = "LFPF";
            this.LFPF.Size = new System.Drawing.Size(81, 13);
            this.LFPF.TabIndex = 5;
            this.LFPF.Text = "Filtro Por Fecha";
            // 
            // LFPU
            // 
            this.LFPU.AutoSize = true;
            this.LFPU.Location = new System.Drawing.Point(104, 176);
            this.LFPU.Name = "LFPU";
            this.LFPU.Size = new System.Drawing.Size(87, 13);
            this.LFPU.TabIndex = 6;
            this.LFPU.Text = "Filtro Por Usuario";
            // 
            // LVendedor
            // 
            this.LVendedor.AutoSize = true;
            this.LVendedor.Location = new System.Drawing.Point(6, 212);
            this.LVendedor.Name = "LVendedor";
            this.LVendedor.Size = new System.Drawing.Size(56, 13);
            this.LVendedor.TabIndex = 7;
            this.LVendedor.Text = "Vendedor:";
            // 
            // BEnviar
            // 
            this.BEnviar.Location = new System.Drawing.Point(194, 285);
            this.BEnviar.Name = "BEnviar";
            this.BEnviar.Size = new System.Drawing.Size(78, 24);
            this.BEnviar.TabIndex = 8;
            this.BEnviar.Text = "Enviar";
            this.BEnviar.UseVisualStyleBackColor = true;
            this.BEnviar.Click += new System.EventHandler(this.BEnviar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(12, 285);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(78, 24);
            this.BCancelar.TabIndex = 9;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormFiltrarVentasSupervisor
            // 
            this.ClientSize = new System.Drawing.Size(290, 321);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BEnviar);
            this.Controls.Add(this.LVendedor);
            this.Controls.Add(this.LFPU);
            this.Controls.Add(this.LFPF);
            this.Controls.Add(this.comboUsuarios);
            this.Controls.Add(this.DTPHasta);
            this.Controls.Add(this.DTPDesde);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Name = "FormFiltrarVentasSupervisor";
            this.Text = "Filtrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.DateTimePicker DTPDesde;
        private System.Windows.Forms.DateTimePicker DTPHasta;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Label LFPF;
        private System.Windows.Forms.Label LFPU;
        private System.Windows.Forms.Label LVendedor;
        private System.Windows.Forms.Button BEnviar;
        private System.Windows.Forms.Button BCancelar;
    }
}