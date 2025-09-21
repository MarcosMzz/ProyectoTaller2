namespace ProyectoTaller
{
    partial class FormAgregarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.BTAgregarUsuario = new System.Windows.Forms.Button();
            this.BTCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Perfil";
            // 
            // CBTipoUsuario
            // 
            this.CBTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTipoUsuario.FormattingEnabled = true;
            this.CBTipoUsuario.Location = new System.Drawing.Point(208, 246);
            this.CBTipoUsuario.Name = "CBTipoUsuario";
            this.CBTipoUsuario.Size = new System.Drawing.Size(182, 29);
            this.CBTipoUsuario.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha De Nacimiento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DTFechaNacimiento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBEmail);
            this.panel1.Controls.Add(this.TBPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBTipoUsuario);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 354);
            this.panel1.TabIndex = 7;
            // 
            // DTFechaNacimiento
            // 
            this.DTFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaNacimiento.Location = new System.Drawing.Point(208, 315);
            this.DTFechaNacimiento.Name = "DTFechaNacimiento";
            this.DTFechaNacimiento.Size = new System.Drawing.Size(182, 29);
            this.DTFechaNacimiento.TabIndex = 12;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(208, 15);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(182, 29);
            this.TBNombre.TabIndex = 8;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(208, 75);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(182, 29);
            this.TBApellido.TabIndex = 9;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(208, 126);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(182, 29);
            this.TBEmail.TabIndex = 10;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(208, 183);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(182, 29);
            this.TBPass.TabIndex = 11;
            // 
            // BTAgregarUsuario
            // 
            this.BTAgregarUsuario.Location = new System.Drawing.Point(100, 437);
            this.BTAgregarUsuario.Name = "BTAgregarUsuario";
            this.BTAgregarUsuario.Size = new System.Drawing.Size(89, 63);
            this.BTAgregarUsuario.TabIndex = 13;
            this.BTAgregarUsuario.Text = "Agregar Usuario";
            this.BTAgregarUsuario.UseVisualStyleBackColor = true;
            this.BTAgregarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTCerrar
            // 
            this.BTCerrar.Location = new System.Drawing.Point(220, 437);
            this.BTCerrar.Name = "BTCerrar";
            this.BTCerrar.Size = new System.Drawing.Size(89, 63);
            this.BTCerrar.TabIndex = 14;
            this.BTCerrar.Text = "Cerrar";
            this.BTCerrar.UseVisualStyleBackColor = true;
            this.BTCerrar.Click += new System.EventHandler(this.cerrarForn);
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 553);
            this.Controls.Add(this.BTCerrar);
            this.Controls.Add(this.BTAgregarUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "FormAgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Usuarios";
            this.Load += new System.EventHandler(this.cargarTiposDePerfiles);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.DateTimePicker DTFechaNacimiento;
        private System.Windows.Forms.Button BTAgregarUsuario;
        private System.Windows.Forms.Button BTCerrar;
    }
}