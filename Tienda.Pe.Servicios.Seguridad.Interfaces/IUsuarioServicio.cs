using System.ServiceModel;
using Tienda.Pe.Transversal.Entidades;
using DAC = Tienda.Pe.Servicios.Seguridad.DataContracts;

namespace Tienda.Pe.Servicios.Seguridad.Interfaces
{
    [ServiceContract]
    public interface IUsuarioServicio
    {
        [OperationContract]
        StatusResponse<DAC.Usuario> Adicionar(DAC.Usuario usuario);
    }
}
