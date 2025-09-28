namespace ProyectoTaller
{
    partial class FormAgregarAutos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBModelo = new System.Windows.Forms.TextBox();
            this.TBStock = new System.Windows.Forms.TextBox();
            this.TBStock_Min = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CBMarcas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock Minimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio";
            // 
            // TBModelo
            // 
            this.TBModelo.Location = new System.Drawing.Point(135, 61);
            this.TBModelo.Name = "TBModelo";
            this.TBModelo.Size = new System.Drawing.Size(424, 20);
            this.TBModelo.TabIndex = 9;
            // 
            // TBStock
            // 
            this.TBStock.Location = new System.Drawing.Point(135, 100);
            this.TBStock.Name = "TBStock";
            this.TBStock.Size = new System.Drawing.Size(70, 20);
            this.TBStock.TabIndex = 10;
            this.TBStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TBStock_Min
            // 
            this.TBStock_Min.Location = new System.Drawing.Point(135, 140);
            this.TBStock_Min.Name = "TBStock_Min";
            this.TBStock_Min.Size = new System.Drawing.Size(70, 20);
            this.TBStock_Min.TabIndex = 11;
            this.TBStock_Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(135, 219);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(152, 20);
            this.TBPrecio.TabIndex = 14;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 79);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar Auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarVehiculo);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 79);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 79);
            this.button3.TabIndex = 20;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CBMarcas
            // 
            this.CBMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMarcas.FormattingEnabled = true;
            this.CBMarcas.Location = new System.Drawing.Point(135, 184);
            this.CBMarcas.Name = "CBMarcas";
            this.CBMarcas.Size = new System.Drawing.Size(152, 21);
            this.CBMarcas.TabIndex = 21;
            // 
            // FormAgregarAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 518);
            this.Controls.Add(this.CBMarcas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TBStock_Min);
            this.Controls.Add(this.TBStock);
            this.Controls.Add(this.TBModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormAgregarAutos";
            this.Text = "Alta de Vehiculo";
            this.Load += new System.EventHandler(this.cargarMarcasVehiculos);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBModelo;
        private System.Windows.Forms.TextBox TBStock;
        private System.Windows.Forms.TextBox TBStock_Min;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CBMarcas;
    }
}