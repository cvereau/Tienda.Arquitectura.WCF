using Autofac;
using Autofac.Integration.Wcf;

namespace Tienda.Pe.Servicios.Seguridad.Host.Modulos
{
    public class Bootstrapper
    {
        public static void LoadContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ContextRepositoryModule>();
            builder.RegisterModule<ServicesModule>();

            AutofacHostFactory.Container = builder.Build();
        }
    }
}