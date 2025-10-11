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
    public partial class FormBackUpDB : Form
    {
        public FormBackUpDB()
        {
            InitializeComponent();
        }

        private void seleccionarRuta(object sender, EventArgs e)
        {
            // 1. Crear una instancia del diálogo para buscar carpetas
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                // Establecer un texto descriptivo para guiar al usuario
                fbd.Description = "Seleccione la carpeta donde se guardará la copia de seguridad (Backup).";

                // Opcional: Establecer una ruta inicial (como el Escritorio o Mi PC)
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;

                // 2. Mostrar el diálogo y verificar si el usuario hizo clic en OK
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // 3. Obtener la ruta seleccionada por el usuario
                    string rutaSeleccionada = fbd.SelectedPath;

                    // 4. Asignar la ruta al TextBox de solo lectura
                    TBRuta.Text = rutaSeleccionada;
                }
                // Si el usuario presiona Cancelar, el diálogo se cierra sin cambiar el TBRuta.
            }
        }
    }
}
