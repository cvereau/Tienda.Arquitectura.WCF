using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class AccesoRepository : Repository<Acceso>, IAccesoRepository
    {
        private readonly TiendaContext _dbContext;

        public AccesoRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Acceso Insertar(Acceso entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<Acceso>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(Acceso entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<Acceso>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
