using Autofac;
using System;
using System.Reflection;
using Tienda.Pe.Datos.IRepositorio.Generico;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Modelo;
using Tienda.Pe.Datos.Repositorio.Generico;
using Tienda.Pe.Datos.UoW;
using Tienda.Pe.Datos.UoW.Implementation;

namespace Tienda.Pe.Servicios.Seguridad.Host.Modulos
{
    public class ContextRepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TiendaContext>().As<TiendaContext>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterAssemblyTypes(Assembly.Load("Tienda.Pe.Datos.Repositorio"))
                .Where(type => type.Name.EndsWith("Repository", StringComparison.Ordinal))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Repository<>))
                .As(typeof(IRepository<>))
                .InstancePerDependency();

            base.Load(builder);
        }
    }
}