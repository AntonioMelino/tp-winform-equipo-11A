using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //public int IdMarca { get; set; }  // Cambiado a int para evitar errores de compilacion al usar base de datos
        //public int IdCategoria { get; set; }  // Cambiado a int para evitar errores de compilacion al usar base de datos
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }
        // DUDAS CON IMAGENES, no se agrega aun en articulo. Se tiene que debatir.
    }
}
