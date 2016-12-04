using Autofac;
using System;
using System.Reflection;

namespace Tienda.Pe.Servicios.Seguridad.Host.Modulos
{
    public class ServicesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("Tienda.Pe.Servicios.Seguridad.Host"))
                .Where(type => type.Name.EndsWith("Servicio", StringComparison.Ordinal))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.Load("Tienda.Pe.Aplicacion.Seguridad"))
                .Where(type => type.Name.EndsWith("Aplicacion", StringComparison.Ordinal))
                .AsImplementedInterfaces();
        }
    }
}