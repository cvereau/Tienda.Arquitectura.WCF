using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Tienda.Pe.Datos.IRepositorio.Generico
{
    public interface IRepository<T> where T : class//, IDisposable
    {
        IEnumerable<T> Listar();
        IEnumerable<T> Listar(Expression<Func<T, bool>> Predicado);
        T Obtener(int id);
        T Insertar(T item);
        void InsertarRange(IEnumerable<T> items);
        void Actualizar(T item);
        void Eliminar(T item);
        void EliminarLogico(T item);
    }
}
