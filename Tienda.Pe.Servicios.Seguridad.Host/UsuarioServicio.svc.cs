using System;
using Tienda.Pe.Servicios.Seguridad.Interfaces;
using Tienda.Pe.Aplicacion.ISeguridad;
using Tienda.Pe.Transversal.Entidades;
using DAC = Tienda.Pe.Servicios.Seguridad.DataContracts;
using APE = Tienda.Pe.Aplicacion.Seguridad.Entidades;
using AutoMapper;
using System.ServiceModel;

namespace Tienda.Pe.Servicios.Seguridad.Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsuarioServicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsuarioServicio.svc or UsuarioServicio.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Single)]
    public class UsuarioServicio : IUsuarioServicio
    {
        private IUsuarioAplicacion usuarioAplicacion;
        public UsuarioServicio(IUsuarioAplicacion usuarioAplicacion)
        {
            this.usuarioAplicacion = usuarioAplicacion;
        }
        public StatusResponse<DAC.Usuario> Adicionar(DAC.Usuario usuario)
        {
            Mapper.CreateMap<DAC.Usuario, APE.Usuario>();
            Mapper.CreateMap<APE.Usuario, DAC.Usuario>();

            var entidadMap = Mapper.Map<APE.Usuario>(usuario);
            var resultado = this.usuarioAplicacion.Adicionar(entidadMap);

            Mapper.CreateMap<StatusResponse<APE.Usuario>, StatusResponse<DAC.Usuario>>();
            var response = Mapper.Map<StatusResponse<DAC.Usuario>>(resultado);

            return response;
        }
    }
}
