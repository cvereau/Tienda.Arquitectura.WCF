using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Pe.Transversal.Mapas.Generico
{
    public class TrimmingConverter : AutoMapper.ITypeConverter<string, string>
    {
        public string Convert(AutoMapper.ResolutionContext context)
        {
            if (context.IsSourceValueNull)
                return null;

            return ((string)context.SourceValue).Trim();
        }
    }
}
