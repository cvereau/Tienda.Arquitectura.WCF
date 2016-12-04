using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.UoW;

namespace Tienda.Pe.Datos.UoW.Implementation
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TiendaContext _context;
        private DbContextTransaction _transaction;

        public UnitOfWork(TiendaContext context)
        {
            _context = context;
        }

        #region Interfaces Members

        public void BeginTransaction(IsolationLevel _isolationLevel)
        {
            if (this._transaction == null)
            {
                _transaction = _context.Database.BeginTransaction(_isolationLevel);
            }            
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
                _transaction?.Commit();
            }
            catch
            {
                _transaction?.Rollback();
                CleanUpTransaction();
                throw;
            }            
            
        }

        public void Rollback()
        {
            _transaction?.Rollback();
            CleanUpTransaction();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion Interfaces Members

        #region Class Members

        public DbContext Context => _context;

        #endregion Class Members

        #region Private Members


        private void CleanUpTransaction()
        {
            _transaction = null;
        }
        private void Dispose(Boolean disposing)
        {
            if (disposing)
            {
                _transaction?.Dispose();
                _context.Dispose();
            }            
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }

        #endregion Private Members
    }
}
