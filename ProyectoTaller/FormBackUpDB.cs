using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void hacerBackUp(object sender, EventArgs e)
        {
            // 1. Recoger la ruta del TextBox y definir la base de datos
            string rutaBackup = TBRuta.Text;
            const string NOMBRE_DB_A_RESPALDAR = "Concesionaria";

            // === 2. Validaciones de la ruta ===
            if (string.IsNullOrWhiteSpace(rutaBackup))
            {
                MessageBox.Show("Por favor, seleccione una ruta de destino para el Backup.", "Error de Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(rutaBackup))
            {
                MessageBox.Show("La carpeta de destino no existe. Por favor, verifique la ruta.", "Error de Ruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // === 3. Inicializar y Ejecutar el Servicio ===
            try
            {
                
                BackupService servicio = new BackupService(ConexionDB.ConnectionString, rutaBackup);

                // Ejecutar la copia de seguridad. El servicio se encarga de crear el nombre único (con hora y minutos).
                servicio.BackupDatabase(NOMBRE_DB_A_RESPALDAR);

                MessageBox.Show($"Copia de seguridad de '{NOMBRE_DB_A_RESPALDAR}' completada con éxito.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar la ruta para que el usuario sepa que terminó.
                TBRuta.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la copia de seguridad. Verifique permisos y ruta:\n{ex.Message}", "Error de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
