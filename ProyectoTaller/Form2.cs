using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Abrir el archivo seleccionado
            System.IO.Stream strm;
            strm = openFileDialog1.OpenFile();

            // Obtiene la ruta del directorio donde está el proyecto
            string cadena = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
            ).Remove(0, 6);

            // Obtiene el nombre completo del archivo seleccionado
            string Source = openFileDialog1.FileName.ToString();

            // Obtiene solo el nombre del archivo
            string archivo = StrSacaValoresString(Source);

            // Ruta destino
            string Destination = cadena + "\\Fotos\\" + archivo;

            // Mostrar la ruta en el TextBox
            textBox8.Text = Destination;
        }

        public string StrSacaValoresString(string RutaPathFichero)
        {
            try
            {
                if (string.IsNullOrEmpty(RutaPathFichero))
                {
                    MessageBox.Show("Debe seleccionar un archivo");
                    return string.Empty;
                }

                return System.IO.Path.GetFileName(RutaPathFichero);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en StrSacaValoresString:\n" + ex.Message,
                                "AVISO DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK){

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
             }
            
        }

        public bool ValidarDatos(string id, string modelo, string stock, string stock_min, string estado, string marca, string precio, string imagen)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(stock) || string.IsNullOrEmpty(stock_min) || string.IsNullOrEmpty(estado) || string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(imagen)) 
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }else if (!(int.TryParse(id, out int id_numero) && int.TryParse(stock, out int stock_numero) && int.TryParse(stock_min, out int stock_min_numero) && double.TryParse(precio, out double precio_numero)))
            {
                MessageBox.Show("no puede poner letras en los campos numericos.");
                return false;
            }
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text))
            {
                form1.AgregarFilasTabla(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox7.Text, pictureBox1.Image);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
