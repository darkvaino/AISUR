using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class RangoDALC
    {
        public List<rango> GetSelectRango()
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                return dbConexion.rango.ToList();
            }
        }
    }
}
