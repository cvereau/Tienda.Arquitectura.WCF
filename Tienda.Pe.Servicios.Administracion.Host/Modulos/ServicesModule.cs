using Autofac;
using System;
using System.Reflection;

namespace Tienda.Pe.Servicios.Administracion.Host.Modulos
{
    public class ServicesModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("Tienda.Pe.Servicios.Administracion.Servicios"))
                .Where(type => type.Name.EndsWith("Servicio", StringComparison.Ordinal))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.Load("Tienda.Pe.Aplicacion.Administracion"))
                .Where(type => type.Name.EndsWith("Aplicacion", StringComparison.Ordinal))
                .AsImplementedInterfaces();
        }
    }
}