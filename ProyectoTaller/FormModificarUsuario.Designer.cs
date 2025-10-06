namespace ProyectoTaller
{
    partial class FormModificarUsuario
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
            this.CBEditarPerfil = new System.Windows.Forms.ComboBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Perfil";
            // 
            // CBEditarPerfil
            // 
            this.CBEditarPerfil.FormattingEnabled = true;
            this.CBEditarPerfil.Location = new System.Drawing.Point(157, 194);
            this.CBEditarPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.CBEditarPerfil.Name = "CBEditarPerfil";
            this.CBEditarPerfil.Size = new System.Drawing.Size(148, 28);
            this.CBEditarPerfil.TabIndex = 5;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(157, 19);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(148, 26);
            this.TBNombre.TabIndex = 6;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(157, 65);
            this.TBApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(148, 26);
            this.TBApellido.TabIndex = 7;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(157, 109);
            this.TBEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(148, 26);
            this.TBEmail.TabIndex = 8;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(157, 149);
            this.TBPass.Margin = new System.Windows.Forms.Padding(2);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(148, 26);
            this.TBPass.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBPass);
            this.panel1.Controls.Add(this.TBEmail);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.CBEditarPerfil);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 264);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 67);
            this.button1.TabIndex = 11;
            this.button1.Text = "Modificar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.modificarUsuarioConfirmar);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 309);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 67);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cerrarFormModificarUsuario);
            // 
            // FormModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormModificarUsuario";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CargarDatos);
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
        private System.Windows.Forms.ComboBox CBEditarPerfil;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}