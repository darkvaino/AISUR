using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ENTIDAD;

namespace DATOS
{
   public  class TipoVehiculoDALC
    {
        public List<tipoVehiculo> GetSelectTipoVehiculo()
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                return dbConexion.tipoVehiculo.ToList();
            }
        }
    }
}
