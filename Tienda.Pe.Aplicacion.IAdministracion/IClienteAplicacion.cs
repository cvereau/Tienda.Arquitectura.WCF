using System.Collections.Generic;
using Tienda.Pe.Transversal.Entidades;
using APE = Tienda.Pe.Aplicacion.Administracion.Entidades;

namespace Tienda.Pe.Aplicacion.IAdministracion
{
    public interface IClienteAplicacion
    {
        StatusResponse<APE.Cliente> Adicionar(APE.Cliente entidad);
        //StatusResponse<APE.Cliente> Modificar(APE.Cliente entidad);
        //StatusResponse<APE.Cliente> Eliminar(int id);
        StatusResponse<List<APE.Cliente>> Listar();
    }
}
