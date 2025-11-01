namespace ProyectoTaller
{
    partial class FormModificarAutos
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
            this.CBMarcas = new System.Windows.Forms.ComboBox();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNModificarAuto = new System.Windows.Forms.Button();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBMarcas
            // 
            this.CBMarcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBMarcas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBMarcas.FormattingEnabled = true;
            this.CBMarcas.Location = new System.Drawing.Point(143, 128);
            this.CBMarcas.Name = "CBMarcas";
            this.CBMarcas.Size = new System.Drawing.Size(152, 21);
            this.CBMarcas.TabIndex = 34;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(206, 218);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(91, 79);
            this.BTNLimpiar.TabIndex = 33;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.limpiarTodosLosCampos);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(330, 218);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(91, 79);
            this.BTNCerrar.TabIndex = 32;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.cerrarForm);
            // 
            // BTNModificarAuto
            // 
            this.BTNModificarAuto.Location = new System.Drawing.Point(78, 218);
            this.BTNModificarAuto.Name = "BTNModificarAuto";
            this.BTNModificarAuto.Size = new System.Drawing.Size(91, 79);
            this.BTNModificarAuto.TabIndex = 31;
            this.BTNModificarAuto.Text = "Modificar Auto";
            this.BTNModificarAuto.UseVisualStyleBackColor = true;
            this.BTNModificarAuto.Click += new System.EventHandler(this.ModificarVehiculo);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(143, 163);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(152, 20);
            this.TBPrecio.TabIndex = 30;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TBStock
            // 
            this.TBStock.Location = new System.Drawing.Point(143, 91);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(70, 20);
            this.TBStock.TabIndex = 28;
            this.TBStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TBModelo
            // 
            this.TBModelo.Location = new System.Drawing.Point(143, 52);
            this.TBModelo.Name = "TBModelo";
            this.TBModelo.Size = new System.Drawing.Size(424, 20);
            this.TBModelo.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Modelo";
            // 
            // FormModificarAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 457);
            this.Controls.Add(this.CBMarcas);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.BTNModificarAuto);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TBStock);
            this.Controls.Add(this.TBModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormModificarAutos";
            this.Text = "FormModificarAutos";
            this.Load += new System.EventHandler(this.preCargarDatos);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBMarcas;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button BTNModificarAuto;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.TextBox TBModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}