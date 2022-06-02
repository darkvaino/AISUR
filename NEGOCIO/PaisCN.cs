using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
    public class PaisCN
    {
        private static PaisDALC obj = new PaisDALC();

        public static List<pais> GetSelectPais()
        {
            return obj.GetSelectPais();
        }
    }
}
