using System.Collections.Generic;
using AutoMapper;
using APE = Tienda.Pe.Aplicacion.Administracion.Entidades;
using DAT = Tienda.Pe.Datos.Entidades;
using Tienda.Pe.Transversal.Entidades;
using Tienda.Pe.Aplicacion.IAdministracion;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Datos.Modelo;
using System;
using Tienda.Pe.Datos.UoW;

namespace Tienda.Pe.Aplicacion.Administracion
{
    public class ClienteAplicacion : IClienteAplicacion
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IClienteRepository clienteRepositorio;
        public ClienteAplicacion(IUnitOfWork unitOfWork, IClienteRepository clienteRepositorio)
        {
            this.unitOfWork = unitOfWork;
            this.clienteRepositorio = clienteRepositorio;
        }

        public StatusResponse<APE.Cliente> Adicionar(APE.Cliente entidad)
        {
            StatusResponse<APE.Cliente> statusResponse;
            try
            {
                //se llama al metodo Insertar del repositorio
                var cliente = clienteRepositorio.Insertar(Mapper.Map<DAT.Cliente>(entidad));
                //se commitean los cambios a traves del unit of work
                this.unitOfWork.Commit();

                statusResponse = new StatusResponse<APE.Cliente>
                {
                    Success = true,
                    Message = "Adicionado Satisfactoriamente.",
                    Data = Mapper.Map<APE.Cliente>(cliente)
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<APE.Cliente>
                {
                    Success = false,
                    Message = "Error en adición de registro."
                };
            }

            return statusResponse;
        }

        public StatusResponse<APE.Cliente> Modificar(APE.Cliente entidad)
        {
            StatusResponse<APE.Cliente> statusResponse;
            try
            {
                this.clienteRepositorio.Actualizar(Mapper.Map<DAT.Cliente>(entidad));

                statusResponse = new StatusResponse<APE.Cliente>
                {
                    Success = true,
                    Message = "Actualizado Satisfactoriamente."
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<APE.Cliente>
                {
                    Success = false,
                    Message = "Error en actualización de registro."
                };
            }

            return statusResponse;
        }

        public StatusResponse<APE.Cliente> Eliminar(int id)
        {
            StatusResponse<APE.Cliente> statusResponse;
            try
            {
                this.clienteRepositorio.EliminarLogico(id);

                statusResponse = new StatusResponse<APE.Cliente>
                {
                    Success = true,
                    Message = "Eliminado Satisfactoriamente."
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<APE.Cliente>
                {
                    Success = false,
                    Message = "Error en Eliminación de registro."
                };
            }

            return statusResponse;
        }

        public StatusResponse<List<APE.Cliente>> Listar()
        {
            StatusResponse<List<APE.Cliente>> statusResponse;
            try
            {
                var lista = clienteRepositorio.Listar();
                var clientes = Mapper.Map<List<APE.Cliente>>(lista);
                statusResponse = new StatusResponse<List<APE.Cliente>>
                {
                    Success = true,
                    Message = "Listado obtenido Satisfactoriamente.",
                    Data= clientes
                };
            }
            catch(Exception e)
            {
                statusResponse = new StatusResponse<List<APE.Cliente>>
                {
                    Success = false,
                    Message = "Error en Listado de registros."
                };
            }

            return statusResponse;
        }
    }
}
