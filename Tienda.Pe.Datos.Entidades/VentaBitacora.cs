using System;

namespace Tienda.Pe.Datos.Entidades
{
    public class VentaBitacora
    {
        public int VentaBitacoraId { get; set; }        
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public int EstadoInicialId { get; set; }
        public int EstadoActualId { get; set; }
        public string comentario { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}
