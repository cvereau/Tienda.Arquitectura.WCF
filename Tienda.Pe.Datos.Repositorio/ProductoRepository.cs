using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;

namespace Tienda.Pe.Datos.Repositorio
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        private readonly TiendaContext _dbContext;

        public ProductoRepository(TiendaContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Producto Insertar(Producto entidad)
        {
            entidad.Activo = true;
            var entidadNueva = _dbContext.Set<Producto>().Add(entidad);
            return entidadNueva;
        }

        public override void Actualizar(Producto entidad)
        {
            entidad.Activo = true;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }

        public override void EliminarLogico(int id)
        {
            var entidad = _dbContext.Set<Producto>().Find(id);
            entidad.Activo = false;
            this._dbContext.Entry(entidad).State = EntityState.Modified;
        }
    }
}
