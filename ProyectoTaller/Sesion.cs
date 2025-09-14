using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller
{
    internal static class Sesion
    {
        public static int UsuarioId { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Email { get; set; }
        public static string Rol { get; set; } // o ID_Perfiles
    }
}
