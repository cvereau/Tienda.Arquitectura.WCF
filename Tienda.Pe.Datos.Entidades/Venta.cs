using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int EstadoId { get; set; }
        public int SedeId { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }        
        public decimal Total { get; set; }
        public decimal TotalReal { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public Estado Estado { get; set; }
        public Sede Sede { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
    }
}
