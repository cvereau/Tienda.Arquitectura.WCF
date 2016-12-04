using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class VentaPagoRepository : Repository<VentaPago>, IVentaPagoRepository
    {
        private readonly TiendaContext _dbContext;

        public VentaPagoRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override VentaPago Insertar(VentaPago entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<VentaPago>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(VentaPago entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<VentaPago>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
