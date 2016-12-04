using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Tienda.Pe.Servicios.Administracion.DataContracts;
using Tienda.Pe.Transversal.Entidades;
using DAC = Tienda.Pe.Servicios.Administracion.DataContracts;

namespace Tienda.Pe.Servicios.Administracion.Interfaces
{
    [ServiceContract]
    public interface IClienteServicio
    {
        [OperationContract]
       // [WebGet(UriTemplate = "/ListarClientes", RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        StatusResponse<List<Cliente>> Listar();

        [OperationContract]
        //  [WebGet(UriTemplate = "/AdicionarCliente", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        StatusResponse<Cliente> Adicionar(DAC.Cliente cliente);
        //POST
        // [WebInvoke(Method = "POST",  UriTemplate = "AddProduct/{productId}/{ProductName}/{ProductDescription}")]
    }
}
