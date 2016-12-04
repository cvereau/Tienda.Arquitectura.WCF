using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        private readonly TiendaContext _dbContext;

        public EstadoRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Estado Insertar(Estado entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<Estado>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(Estado entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<Estado>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
