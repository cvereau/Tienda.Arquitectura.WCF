using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly TiendaContext _dbContext;
        public ClienteRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override Cliente Insertar(Cliente entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<Cliente>().Add(entidad);
            return entidadNueva;
        }
        public override void Actualizar(Cliente entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set <Cliente>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
