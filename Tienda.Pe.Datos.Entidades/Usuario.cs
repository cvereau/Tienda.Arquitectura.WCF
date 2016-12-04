using System;
using System.Collections.Generic;

namespace Tienda.Pe.Datos.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }        
        public string Clave { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}
