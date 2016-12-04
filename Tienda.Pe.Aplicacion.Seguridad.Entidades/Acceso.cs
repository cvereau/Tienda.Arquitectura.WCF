using System;

namespace Tienda.Pe.Aplicacion.Seguridad.Entidades
{
    public class Acceso
    {
        public int AccesoId { set; get; }
        public string Ruta { set; get; }
        public bool Activo { set; get; }
    }
}
