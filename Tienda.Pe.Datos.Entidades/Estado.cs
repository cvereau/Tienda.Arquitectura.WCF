using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}
