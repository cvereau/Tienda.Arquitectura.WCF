using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Datos.UoW
{ 
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        void BeginTransaction(IsolationLevel _isolationLevel = IsolationLevel.ReadCommitted);

        void Commit();
     
        void Rollback();

        void SaveChanges();
    }
}
