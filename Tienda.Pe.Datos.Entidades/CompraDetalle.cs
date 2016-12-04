using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.Entidades
{
    public class CompraDetalle
    {
        public int CompraDetalleId { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int SedeId { get; set; }
        public int Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }
        //public decimal CostoCalculado { get; set; }
        //public decimal CostoReal { get; set; }
        //public decimal PrecioUnitario{ get; set; }        
        //public decimal PrecioReal { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }


        public Compra Compra { get; set; }
        public Sede Sede { get; set; }
        public Producto Producto { get; set; }
    }
}
