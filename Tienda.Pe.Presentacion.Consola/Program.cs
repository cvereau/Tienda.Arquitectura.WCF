using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Presentacion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            clienteServicio.ClienteServicioClient clienteServ = new clienteServicio.ClienteServicioClient();
            var lista = clienteServ.Listar();
            //usuarioServicio.UsuarioServicioClient usuarioServicio = new usuarioServicio.UsuarioServicioClient();
            //usuarioServicio.Adicionar();

            System.Console.ReadKey();
        }
    }
}
