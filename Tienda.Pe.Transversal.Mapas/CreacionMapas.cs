using AutoMapper;
using Tienda.Pe.Transversal.Mapas.Generico;

namespace Tienda.Pe.Transversal.Mapas
{
    public class CreacionMapas
    {
        private CreacionMapas()
        {
            Mapper.CreateMap<string, string>().ConvertUsing(new TrimmingConverter());

            Administracion.CrearMapas();
            Seguridad.CrearMapas();
        }
        public static void Crear()
        {
            var instancia = Singleton<CreacionMapas>.Instancia;
        }
    }
}