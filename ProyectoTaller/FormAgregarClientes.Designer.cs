namespace ProyectoTaller
{
    partial class FormAgregarClientes
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
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBNroTelefono = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNAgregarC = new System.Windows.Forms.Button();
            this.BTLimpiar = new System.Windows.Forms.Button();
            this.DTCliente = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(218, 56);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(248, 20);
            this.TBNombre.TabIndex = 0;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(218, 101);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(248, 20);
            this.TBApellido.TabIndex = 1;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(218, 147);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(248, 20);
            this.TBDni.TabIndex = 2;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(218, 196);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(248, 20);
            this.TBEmail.TabIndex = 3;
            // 
            // TBNroTelefono
            // 
            this.TBNroTelefono.Location = new System.Drawing.Point(218, 237);
            this.TBNroTelefono.Name = "TBNroTelefono";
            this.TBNroTelefono.Size = new System.Drawing.Size(248, 20);
            this.TBNroTelefono.TabIndex = 4;
            this.TBNroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(218, 279);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(248, 20);
            this.TBDireccion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Direccion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 318);
            this.panel1.TabIndex = 12;
            // 
            // BTNAgregarC
            // 
            this.BTNAgregarC.Location = new System.Drawing.Point(29, 384);
            this.BTNAgregarC.Name = "BTNAgregarC";
            this.BTNAgregarC.Size = new System.Drawing.Size(112, 44);
            this.BTNAgregarC.TabIndex = 13;
            this.BTNAgregarC.Text = "Agregar";
            this.BTNAgregarC.UseVisualStyleBackColor = true;
            this.BTNAgregarC.Click += new System.EventHandler(this.agregarCliente);
            // 
            // BTLimpiar
            // 
            this.BTLimpiar.Location = new System.Drawing.Point(184, 384);
            this.BTLimpiar.Name = "BTLimpiar";
            this.BTLimpiar.Size = new System.Drawing.Size(112, 44);
            this.BTLimpiar.TabIndex = 14;
            this.BTLimpiar.Text = "Limpiar Campos";
            this.BTLimpiar.UseVisualStyleBackColor = true;
            this.BTLimpiar.Click += new System.EventHandler(this.limpiarCampos);
            // 
            // DTCliente
            // 
            this.DTCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTCliente.Location = new System.Drawing.Point(277, 323);
            this.DTCliente.Name = "DTCliente";
            this.DTCliente.Size = new System.Drawing.Size(113, 20);
            this.DTCliente.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cerrarVentana);
            // 
            // FormAgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTCliente);
            this.Controls.Add(this.BTLimpiar);
            this.Controls.Add(this.BTNAgregarC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.TBNroTelefono);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBNombre);
            this.Name = "FormAgregarClientes";
            this.Text = "te";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBNroTelefono;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNAgregarC;
        private System.Windows.Forms.Button BTLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTCliente;
        private System.Windows.Forms.Button button1;
    }
}