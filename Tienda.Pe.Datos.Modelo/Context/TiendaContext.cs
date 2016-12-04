using System.Configuration;
using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.Modelo.Mapping;
namespace Tienda.Pe.Datos.Modelo.Context
{
    public class TiendaContext : DbContext
    {
        public TiendaContext():base(ConfigurationManager.ConnectionStrings["TiendaConnection"].ConnectionString)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TiendaContext>());
            modelBuilder.Configurations.Add(new RolMapping());
            modelBuilder.Configurations.Add(new RolAccesoMapping());
            modelBuilder.Configurations.Add(new AccesoMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new CuentaMapping());
            modelBuilder.Configurations.Add(new EstadoMapping());
            modelBuilder.Configurations.Add(new CategoriaMapping());
            modelBuilder.Configurations.Add(new MarcaMapping());
            modelBuilder.Configurations.Add(new SedeMapping());
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new ProductoMapping());
            modelBuilder.Configurations.Add(new CompraDetalleMapping());
            modelBuilder.Configurations.Add(new CompraMapping());
            modelBuilder.Configurations.Add(new VentaDetalleMapping());
            modelBuilder.Configurations.Add(new VentaMapping());
            modelBuilder.Configurations.Add(new VentaPagoMapping());
            modelBuilder.Configurations.Add(new VentaBitacoraMapping());
        }
        
        public virtual IDbSet<Rol> Rol { get; set; }
        public virtual IDbSet<RolAcceso> RolAcceso { get; set; }
        public virtual IDbSet<Acceso> Acceso { get; set; }
        public virtual IDbSet<Usuario> Usuario { get; set; }
        public virtual IDbSet<Cuenta> Cuenta { get; set; }
        public virtual IDbSet<Estado> Estado { get; set; }
        public virtual IDbSet<Categoria> Categoria { get; set; }
        public virtual IDbSet<Marca> Marca { get; set; }
        public virtual IDbSet<Sede> Sede { get; set; }
        public virtual IDbSet<Cliente> Cliente { get; set; }
        public virtual IDbSet<Producto> Producto { get; set; }
        public virtual IDbSet<CompraDetalle> CompraDetalle { get; set; }
        public virtual IDbSet<Compra> Compra { get; set; }
        public virtual IDbSet<VentaDetalle> VentaDetalle { get; set; }
        public virtual IDbSet<VentaPago> VentaPago { get; set; }
        public virtual IDbSet<Venta> Venta { get; set; }       
        public virtual IDbSet<VentaBitacora> VentaBitacora { get; set; }
    }
}
