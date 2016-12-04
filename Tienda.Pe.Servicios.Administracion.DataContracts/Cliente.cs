using System;
using System.Runtime.Serialization;

namespace Tienda.Pe.Servicios.Administracion.DataContracts
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int ClienteId { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string ApellidoPaterno { get; set; }
        [DataMember]
        public string ApellidoMaterno { get; set; }
        [DataMember]
        public string Documento { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public bool Activo { get; set; }
    }
}
