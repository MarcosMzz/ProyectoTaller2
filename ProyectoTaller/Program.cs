using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new FormLogin();

            if (login.ShowDialog() == DialogResult.OK)
            {
                // 2. Si el login fue exitoso, abrimos el FormPrincipal.
                FormPrincipal principal = new FormPrincipal();
                Application.Run(principal);
                
            }
        }
    }
}
