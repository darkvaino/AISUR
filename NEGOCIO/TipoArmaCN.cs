using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class TipoArmaCN
    {
        private static TipoArmaDALC obj = new TipoArmaDALC();

        public static List<tipoArma> GetSelectTipoArma()
        {
            return obj.GetSelectTipoArma();
        }
        
    }
}
