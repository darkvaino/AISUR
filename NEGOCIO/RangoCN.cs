using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
    public class RangoCN
    {
        private static RangoDALC obj = new RangoDALC();

        public static List<rango> GetSelectRango()
        {
            return obj.GetSelectRango();
        }
    }
}
