using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }       
        //public int Stock { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

        public Categoria  Categoria{ get; set; }
        public Marca Marca { get; set; }
    }
}
