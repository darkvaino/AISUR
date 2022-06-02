using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
     public class PaisDALC
    {
        public List<pais> GetSelectPais()
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                return dbConexion.pais.ToList();
            }
        }
    }
}
