using AutoMapper;
using System;
using System.Collections.Generic;
using Tienda.Pe.Aplicacion.ISeguridad;
using Tienda.Pe.Datos.IRepositorio;
using Tienda.Pe.Transversal.Entidades;
using APE = Tienda.Pe.Aplicacion.Seguridad.Entidades;
using DAT = Tienda.Pe.Datos.Entidades;

namespace Tienda.Pe.Aplicacion.Seguridad
{
    public class UsuarioAplicacion : IUsuarioAplicacion
    {
        private readonly IUsuarioRepository usuarioRepositorio;
        public UsuarioAplicacion(IUsuarioRepository usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }
        public StatusResponse<APE.Usuario> Adicionar(APE.Usuario entidad)
        {
            StatusResponse<APE.Usuario> statusResponse;
            try
            {
                Mapper.CreateMap<APE.Usuario, DAT.Usuario>();
                Mapper.CreateMap<DAT.Usuario, APE.Usuario>();

                var cliente = usuarioRepositorio.Insertar(Mapper.Map<DAT.Usuario>(entidad));
                usuarioRepositorio.Save();
                statusResponse = new StatusResponse<APE.Usuario>
                {
                    Success = true,
                    Message = "Adicionado Satisfactoriamente.",
                    Data =  Mapper.Map<APE.Usuario>(cliente)
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<APE.Usuario>
                {
                    Success = false,
                    Message = "Error en adición de registro."
                };
            }

            return statusResponse;
        }
        public StatusResponse<APE.Usuario> Modificar(APE.Usuario entidad)
        {
            StatusResponse<APE.Usuario> statusResponse;
            try
            {
                this.usuarioRepositorio.Actualizar(Mapper.Map<DAT.Usuario>(entidad));
                statusResponse = new StatusResponse<APE.Usuario>
                {
                    Success = true,
                    Message = "Actualizado Satisfactoriamente."
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<APE.Usuario>
                {
                    Success = false,
                    Message = "Error en actualización de registro."
                };
            }

            return statusResponse;
        }
        public StatusResponse<APE.Usuario> Eliminar(int id)
        {
            StatusResponse<APE.Usuario> statusResponse;
            try
            {
                this.usuarioRepositorio.EliminarLogico(id);
                statusResponse = new StatusResponse<APE.Usuario>
                {
                    Success = true,
                    Message = "Eliminado Satisfactoriamente."
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<APE.Usuario>
                {
                    Success = false,
                    Message = "Error en Eliminación de registro."
                };
            }

            return statusResponse;
        }
        public StatusResponse<List<APE.Usuario>> Listar()
        {
            StatusResponse<List<APE.Usuario>> statusResponse;
            try
            {
                var lista = usuarioRepositorio.Listar();
                var clientes = Mapper.Map<List<APE.Usuario>>(lista);
                statusResponse = new StatusResponse<List<APE.Usuario>>
                {
                    Success = true,
                    Message = "Listado obtenido Satisfactoriamente.",
                    Data = clientes
                };
            }
            catch (Exception e)
            {
                statusResponse = new StatusResponse<List<APE.Usuario>>
                {
                    Success = false,
                    Message = "Error en Listado de registros."
                };
            }

            return statusResponse;
        }
    }
}
