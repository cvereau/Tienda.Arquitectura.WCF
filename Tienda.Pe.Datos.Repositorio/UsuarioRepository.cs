using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly TiendaContext _dbContext;

        public UsuarioRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Usuario Insertar(Usuario entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<Usuario>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(Usuario entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<Usuario>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
