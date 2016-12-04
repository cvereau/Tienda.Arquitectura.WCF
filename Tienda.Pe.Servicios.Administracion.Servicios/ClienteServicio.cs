using AutoMapper;
using System.Collections.Generic;
using System.ServiceModel;
using Tienda.Pe.Aplicacion.IAdministracion;
using Tienda.Pe.Servicios.Administracion.DataContracts;
using Tienda.Pe.Servicios.Administracion.Interfaces;
using Tienda.Pe.Transversal.Entidades;

using DAC = Tienda.Pe.Servicios.Administracion.DataContracts;
using APE = Tienda.Pe.Aplicacion.Administracion.Entidades;

namespace Tienda.Pe.Servicios.Administracion.Servicios
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Single)]
    public class ClienteServicio : IClienteServicio
    {
        private readonly IClienteAplicacion clienteAplicacion;
        public ClienteServicio(IClienteAplicacion clienteAplicacion)
        {
            this.clienteAplicacion = clienteAplicacion;
        }

        public StatusResponse<List<Cliente>> Listar()
        {
            var resultado = this.clienteAplicacion.Listar();
            var statusResponse = Mapper.Map<StatusResponse<List<DAC.Cliente>>>(resultado);
            return statusResponse;
        }

        public StatusResponse<Cliente> Adicionar(DAC.Cliente cliente)
        {
            //var cliente = new DAC.Cliente
            //{
            //    Activo=true,
            //    ApellidoMaterno="sdfsdf",
            //    ApellidoPaterno="sdfsdf",
            //    Correo="sdfsdf",
            //    Direccion="fdfsdfdf",
            //    Documento="23434234",
            //    Fecha=System.DateTime.Now,
            //    Nombres="dfadasdad",
            //    Telefono="111132"
            //};

            var resultado = this.clienteAplicacion.Adicionar(Mapper.Map<APE.Cliente>(cliente));
            var statusResponse = Mapper.Map<StatusResponse<DAC.Cliente>>(resultado);
            return statusResponse;
        }
    }
}
