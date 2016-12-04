using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class CuentaRepository : Repository<Cuenta>, ICuentaRepository
    {
        private readonly TiendaContext _dbContext;

        public CuentaRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Cuenta Insertar(Cuenta entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<Cuenta>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(Cuenta entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<Cuenta>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
