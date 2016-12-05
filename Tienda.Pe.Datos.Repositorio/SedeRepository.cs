using System.Data.Entity;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Repositorio.Generico;
using Tienda.Pe.Datos.UoW;

namespace Tienda.Pe.Datos.Repositorio
{
    public class SedeRepository : Repository<Sede>, ISedeRepository
    {
        readonly IUnitOfWork unitOfWork;
        public SedeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public override Sede Insertar(Sede entidad)
        {
            entidad.Activo = true;
            var entidadNueva = base.Insertar(entidad);
            this.unitOfWork.Commit();
            return entidadNueva;
        }
        public override void Actualizar(Sede entidad)
        {
            entidad.Activo = true;
            base.Actualizar(entidad);
            this.unitOfWork.Commit();
        }
        public override void EliminarLogico(int id)
        {
            base.EliminarLogico(id);
            this.unitOfWork.Commit();
        }
    }
}