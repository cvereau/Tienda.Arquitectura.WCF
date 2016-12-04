using System;
using System.Collections.Generic;

using AutoMapper;
using APE = Tienda.Pe.Aplicacion.Administracion.Entidades;
using DAT = Tienda.Pe.Datos.Entidades;
using DAC = Tienda.Pe.Servicios.Administracion.DataContracts;
using Tienda.Pe.Transversal.Entidades;

namespace Tienda.Pe.Transversal.Mapas
{
    public class Administracion
    {
        internal static void CrearMapas()
        {
            Mapper.CreateMap<DAC.Cliente, APE.Cliente>();
            Mapper.CreateMap<APE.Cliente, DAT.Cliente>();
            Mapper.CreateMap<DAT.Cliente, APE.Cliente>();
            Mapper.CreateMap<APE.Cliente, DAC.Cliente>();

            Mapper.CreateMap< StatusResponse<DAC.Cliente>, StatusResponse<APE.Cliente>>();
            Mapper.CreateMap< StatusResponse<APE.Cliente>, StatusResponse<DAT.Cliente>>();
            Mapper.CreateMap< StatusResponse<DAT.Cliente>, StatusResponse<APE.Cliente>>();
            Mapper.CreateMap< StatusResponse<APE.Cliente>, StatusResponse<DAC.Cliente>>();

            Mapper.CreateMap<StatusResponse<List<APE.Cliente>>, StatusResponse<List<DAT.Cliente>>>();
            Mapper.CreateMap<StatusResponse<List<DAT.Cliente>>, StatusResponse<List<APE.Cliente>>>();
            Mapper.CreateMap<StatusResponse<List<APE.Cliente>>, StatusResponse<List<DAC.Cliente>>>();
            Mapper.CreateMap<StatusResponse<List<DAC.Cliente>>, StatusResponse<List<APE.Cliente>>>();
        }
    }
}
