using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class VentaDetalle
    {
        public int VentaDetalleId { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio{ get; set; }
        public decimal PrecioVenta { get; set; } 
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public bool Activo { get; set; }

        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
    }
}
