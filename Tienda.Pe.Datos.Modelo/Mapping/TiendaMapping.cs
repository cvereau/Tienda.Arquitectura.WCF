using Tienda.Pe.Datos.Entidades;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda.Pe.Datos.Modelo.Mapping
{
    public class RolMapping : EntityTypeConfiguration<Rol>
    {
        public RolMapping()
        {
            ToTable("Rol", "Seguridad");
            HasKey(x => x.RolId);
            Property(x => x.RolId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombre).HasMaxLength(100).IsRequired();          
            Property(x => x.Descripcion).HasMaxLength(250).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }
    public class RolAccesoMapping : EntityTypeConfiguration<RolAcceso>
    {
        public RolAccesoMapping()
        {
            ToTable("RolAcceso", "Seguridad");
            HasKey(x => x.RolAccesoId);
            Property(x => x.RolAccesoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired(x => x.Rol)
                .WithMany()
                .HasForeignKey(x => x.RolId);
            HasRequired(x => x.Acceso)
                .WithMany()
                .HasForeignKey(x => x.AccesoId);

            Property(x => x.Activo).IsRequired();
        }
    }

    public class AccesoMapping : EntityTypeConfiguration<Acceso>
    {
        public AccesoMapping()
        {
            ToTable("Acceso", "Seguridad");
            HasKey(x => x.AccesoId);
            Property(x => x.AccesoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Ruta).HasMaxLength(500).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("Usuario", "Seguridad");
            HasKey(x => x.UsuarioId);
            Property(x => x.UsuarioId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombres).HasMaxLength(100).IsRequired();
            Property(x => x.ApellidoPaterno).HasMaxLength(100).IsRequired();
            Property(x => x.ApellidoMaterno).HasMaxLength(100).IsRequired();
            Property(x => x.Documento).HasMaxLength(15).IsRequired();
            Property(x => x.Direccion).HasMaxLength(250).IsRequired();
            Property(x => x.Telefono).HasMaxLength(20).IsRequired();
            Property(x => x.Correo).HasMaxLength(100).IsOptional();
            Property(x => x.Clave).HasMaxLength(50).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }
    public class CuentaMapping : EntityTypeConfiguration<Cuenta>
    {
        public CuentaMapping()
        {
            ToTable("Cuenta", "Seguridad");
            HasKey(x => x.CuentaId);
            Property(x => x.CuentaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.UsuarioId);
            HasRequired(x => x.Sede)
                .WithMany()
                .HasForeignKey(x => x.SedeId);
            HasRequired(x => x.Rol)
                .WithMany()
                .HasForeignKey(x => x.RolId);
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public EstadoMapping()
        {
            ToTable("Estado", "Administracion");
            HasKey(x => x.EstadoId);
            Property(x => x.EstadoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class CategoriaMapping : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMapping()
        {
            ToTable("Categoria", "Administracion");
            HasKey(x => x.CategoriaId);
            Property(x => x.CategoriaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            Property(x => x.Descripcion).HasMaxLength(250).IsOptional();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class MarcaMapping : EntityTypeConfiguration<Marca>
    {
        public MarcaMapping()
        {
            ToTable("Marca", "Administracion");
            HasKey(x => x.MarcaId);
            Property(x => x.MarcaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            Property(x => x.Descripcion).HasMaxLength(250).IsOptional();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class SedeMapping : EntityTypeConfiguration<Sede>
    {
        public SedeMapping()
        {
            ToTable("Sede", "Administracion");
            HasKey(x => x.SedeId);
            Property(x => x.SedeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            Property(x => x.Direccion).HasMaxLength(250).IsOptional();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping()
        {
            ToTable("Cliente", "Administracion");
            HasKey(x => x.ClienteId);
            Property(x => x.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nombres).HasMaxLength(100).IsRequired();
            Property(x => x.ApellidoPaterno).HasMaxLength(100).IsRequired();
            Property(x => x.ApellidoMaterno).HasMaxLength(100).IsRequired();
            Property(x => x.Documento).HasMaxLength(15).IsRequired();
            Property(x => x.Direccion).HasMaxLength(250).IsRequired();
            Property(x => x.Telefono).HasMaxLength(20).IsRequired();
            Property(x => x.Correo).HasMaxLength(100).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class ProductoMapping : EntityTypeConfiguration<Producto>
    {
        public ProductoMapping()
        {
            ToTable("Producto", "Almacen");
            HasKey(x => x.ProductoId);
            Property(x => x.ProductoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CategoriaId).IsRequired();
            Property(x => x.MarcaId).IsRequired();

            Property(x => x.Nombre).HasMaxLength(100).IsRequired();
            Property(x => x.Descripcion).HasMaxLength(250).IsOptional();            
            //Property(x => x.Stock).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class CompraDetalleMapping : EntityTypeConfiguration<CompraDetalle>
    {
        public CompraDetalleMapping()
        {
            ToTable("CompraDetalle", "Almacen");
            HasKey(x => x.CompraDetalleId);
            Property(x => x.CompraDetalleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired(x => x.Compra)
               .WithMany()
               .HasForeignKey(x => x.CompraId);
            HasRequired(x => x.Producto)
               .WithMany()
               .HasForeignKey(x => x.ProductoId);
            HasRequired(x => x.Sede)
               .WithMany()
               .HasForeignKey(x => x.SedeId);

            Property(x => x.Cantidad).IsRequired();
            Property(x => x.CostoUnitario).HasPrecision(18, 4).IsRequired();
            //Property(x => x.CostoCalculado).HasPrecision(18, 4).IsRequired();
            //Property(x => x.CostoReal).HasPrecision(18, 4).IsRequired();
            //Property(x => x.PrecioUnitario).HasPrecision(18, 4).IsRequired();            
            //Property(x => x.PrecioReal).HasPrecision(18, 4).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class CompraMapping : EntityTypeConfiguration<Compra>
    {
        public CompraMapping()
        {
            ToTable("Compra", "Almacen");
            HasKey(x => x.CompraId);
            Property(x => x.CompraId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Usuario)
               .WithMany()
               .HasForeignKey(x => x.UsuarioId);

            Property(x => x.Descripcion).HasMaxLength(250).IsOptional();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class VentaDetalleMapping : EntityTypeConfiguration<VentaDetalle>
    {
        public VentaDetalleMapping()
        {
            ToTable("VentaDetalle", "Ventas");
            HasKey(x => x.VentaDetalleId);
            Property(x => x.VentaDetalleId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired(x => x.Venta)
               .WithMany()
               .HasForeignKey(x => x.VentaId);
            HasRequired(x => x.Producto)
              .WithMany()
              .HasForeignKey(x => x.ProductoId);
            Property(x => x.Costo).HasPrecision(18, 4).IsRequired();
            Property(x => x.Precio).HasPrecision(18, 4).IsRequired();
            Property(x => x.PrecioVenta).HasPrecision(18, 4).IsRequired();
            Property(x => x.Cantidad).IsRequired();
            Property(x => x.Subtotal).HasPrecision(18, 4).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class VentaMapping : EntityTypeConfiguration<Venta>
    {
        public VentaMapping()
        {
            ToTable("Venta", "Ventas");
            HasKey(x => x.VentaId);
            Property(x => x.VentaId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Estado)
               .WithMany()
               .HasForeignKey(x => x.EstadoId);
            HasRequired(x => x.Sede)
               .WithMany()
               .HasForeignKey(x => x.SedeId);
            HasRequired(x => x.Usuario)
               .WithMany()
               .HasForeignKey(x => x.UsuarioId);
            HasRequired(x => x.Cliente)
               .WithMany()
               .HasForeignKey(x => x.ClienteId);

            Property(x => x.Total).HasPrecision(18, 4).IsRequired();
            Property(x => x.TotalReal).HasPrecision(18, 4).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class VentaPagoMapping : EntityTypeConfiguration<VentaPago>
    {
        public VentaPagoMapping()
        {
            ToTable("VentaPago", "Ventas");
            HasKey(x => x.VentaPagoId);
            Property(x => x.VentaPagoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(x => x.Venta)
                .WithMany()
                .HasForeignKey(x => x.VentaId).WillCascadeOnDelete(false);
            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.UsuarioId);

            Property(x => x.Descripcion).HasMaxLength(250).IsRequired();
            Property(x => x.Monto).HasPrecision(18, 4).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }

    public class VentaBitacoraMapping : EntityTypeConfiguration<VentaBitacora>
    {
        public VentaBitacoraMapping()
        {
            ToTable("VentaBitacora", "Ventas");
            HasKey(x => x.VentaBitacoraId);
            Property(x => x.VentaBitacoraId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            Property(x => x.VentaId).IsRequired();
            Property(x => x.UsuarioId).IsRequired();
            Property(x => x.EstadoInicialId).IsRequired();
            Property(x => x.EstadoActualId).IsRequired();
            Property(x => x.comentario).HasMaxLength(250).IsRequired();
            Property(x => x.Fecha).IsRequired();
            Property(x => x.Activo).IsRequired();
        }
    }
}
