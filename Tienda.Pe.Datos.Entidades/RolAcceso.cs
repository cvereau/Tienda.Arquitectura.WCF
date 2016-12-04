using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class RolAcceso
    {
        public int RolAccesoId { get; set; }
        public int RolId { get; set; }
        public int AccesoId { get; set; }
        public bool Activo { get; set; }

        public Rol Rol { get; set; }
        public Acceso Acceso { get; set; }
    }
}
