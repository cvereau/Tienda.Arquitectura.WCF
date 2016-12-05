using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tienda.Pe.Datos.IRepositorio.Generico;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.UoW;
//quita esta referencia y el ensamblado cuando metas Autofac
using Tienda.Pe.Datos.UoW.Implementation;

using static System.Diagnostics.Contracts.Contract;

namespace Tienda.Pe.Datos.Repositorio.Generico
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly IUnitOfWork unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public virtual IEnumerable<T> Listar()
        {
            this.unitOfWork.BeginTransaction();
            return this.unitOfWork.Context.Set<T>().ToList();
        }
        public virtual IEnumerable<T> Listar(Expression<Func<T, bool>> Predicado)
        {
            this.unitOfWork.BeginTransaction();
            return this.unitOfWork.Context.Set<T>().Where(Predicado).ToList();
        }
        public virtual T Obtener(int id)
        {
            //var respuesta = context.Set<T>().Find(id);
            //return respuesta;
            this.unitOfWork.BeginTransaction();
            return this.unitOfWork.Context.Set<T>().Find(id);
        }
        public virtual T Insertar(T item)
        {
            //var entidadNueva = context.Set<T>().Add(entidad);
            //return entidadNueva;
            this.unitOfWork.BeginTransaction();
            var entidadNueva = this.unitOfWork.Context.Set<T>().Add(item);
            return entidadNueva;
        }

        public virtual void InsertarRange(IEnumerable<T> items)
        {
            var insertarRange = items as T[] ?? items.ToArray();
            foreach (var item in insertarRange)
            {
                Insertar(item);
            }
        }

        public virtual void Actualizar(T item)
        {
            this.unitOfWork.Context.Entry(item).State = EntityState.Modified;
        }

        public void Eliminar(T item)
        {
            this.unitOfWork.BeginTransaction();
            this.unitOfWork.Context.Set<T>().Remove(item);
        }

        public virtual void EliminarLogico(int item)
        {
            var entidad = Obtener(item);
            this.unitOfWork.Context.Entry(entidad).State = EntityState.Deleted;
        }
    }
}
