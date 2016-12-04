using System;

namespace Tienda.Pe.Datos.Entidades
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public int UsuarioId { get; set; }
        public int SedeId { get; set; }
        public int RolId { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

        public Usuario Usuario { get; set; }
        public Sede Sede { get; set; }
        public Rol Rol { get; set; }
    }
}
