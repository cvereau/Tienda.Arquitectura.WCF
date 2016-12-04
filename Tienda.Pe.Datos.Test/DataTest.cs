using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tienda.Pe.Datos.Modelo.Context;
using Tienda.Pe.Datos.Entidades;

namespace Tienda.Pe.Datos.Test
{
    [TestClass]
    public class DataTest
    {
        
        [TestMethod]
        public void insertCliente()
        {
            var context = new TiendaContext();

            var cliente = new Cliente
            {
                ApellidoMaterno ="Cuento",
                ApellidoPaterno ="Vargas",
                Correo ="vargas.cueto.jp@gmail.com",
                Direccion="Jr.Agata #1377",
                Nombres="Jean Pierre",
                Telefono="973108839"
            };
            context.Cliente.Add(cliente);
            context.SaveChanges();
        }
    }
}
