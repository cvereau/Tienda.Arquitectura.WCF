using System;

namespace Tienda.Pe.Aplicacion.Seguridad.Entidades
{
    public class RolAcceso
    {
        public int RolAccesoId { get; set; }
        public int RolId { get; set; }
        public int AccesoId { get; set; }
        public bool Activo { get; set; }

        //public Rol Rol { get; set; }
        //public Acceso Acceso { get; set; }
    }
}
