using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller
{
    internal class DetalleTemporal // 'internal' está bien, solo es accesible dentro del proyecto
    {
        // Propiedades clave que necesitamos para mostrar en el DataGrid y para guardar en la DB

        public int ID_Auto { get; set; } // Necesario para buscar stock y guardar el detalle
        public string Modelo { get; set; }
        public string Marca { get; set; } // Obtenido de la DB
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        // Propiedad calculada: se calcula automáticamente al acceder a ella
        public decimal SubTotal
        {
            get { return PrecioUnitario * Cantidad; }
        }
    }
}