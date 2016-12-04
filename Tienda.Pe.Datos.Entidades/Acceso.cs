using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class Acceso
    {
        public int AccesoId { set; get; }
        public string Ruta { set; get; }
        public bool Activo { set; get; }
    }
}
