using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.IRepositorio.Generico;
//using Tienda.Pe.Datos.Repositorio.Generico;
using Tienda.Pe.Datos.Modelo.Context;

namespace Tienda.Pe.Datos.Modelo
{
    public class UnitOfWork //: IDisposable
    {
        private TiendaContext context; //= new TiendaContext();
        private IClienteRepository clienteRepository;

        public UnitOfWork(TiendaContext context, IClienteRepository clienteRepository)
        {
            this.context = context;
            this.clienteRepository = clienteRepository;
        }

        public IRepository<Cliente> ClienteRepository
        {
            get
            {
                return this.clienteRepository;
            }
        }
        public void Dispose()
        {
            if (context != null)
            {
                this.context.Dispose();
            }
        }
        public void Save()
        {
            this.context.SaveChanges();
        }

    }
}
