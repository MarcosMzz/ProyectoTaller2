using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller
{
    public static class ConexionDB
    {
        // 'const' garantiza que la cadena no se pueda modificar, y es accesible para toda la aplicación.
        public const string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Concesionaria;Integrated Security=True";
    }
}
