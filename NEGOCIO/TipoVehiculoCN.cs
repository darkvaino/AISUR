using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
    public class TipoVehiculoCN
    {
        private static TipoVehiculoDALC obj = new TipoVehiculoDALC();

        public static List<tipoVehiculo> GetSelectTipoVehiculo()
        {
            return obj.GetSelectTipoVehiculo();
        }
    }
}
