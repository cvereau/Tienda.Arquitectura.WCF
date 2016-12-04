using System.Collections.Generic;

namespace Tienda.Pe.Transversal.Entidades
{
    public class StatusResponse<T> 
    {
        public string Message { get; set; }
        public List<string> Messages { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public List<T> Lista { get; set; }
    }
}
