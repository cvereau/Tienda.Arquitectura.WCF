using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class VentaPago
    {
        public int VentaPagoId { get; set; }
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }


        public Venta Venta { get; set; }
        public Usuario Usuario { get; set; }
    }
}
