using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class VentaDetalleRepository : Repository<VentaDetalle>, IVentaDetalleRepository
    {
        private readonly TiendaContext _dbContext;

        public VentaDetalleRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override VentaDetalle Insertar(VentaDetalle entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<VentaDetalle>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(VentaDetalle entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<VentaDetalle>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
