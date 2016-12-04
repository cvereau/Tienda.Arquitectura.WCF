using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class Compra
    {
        public int CompraId { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }        
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

        public Usuario Usuario { get; set; }
    }
}
