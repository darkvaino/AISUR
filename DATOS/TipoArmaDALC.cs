using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DATOS
{
    public class TipoArmaDALC
    {
        
        public List<tipoArma> GetSelectTipoArma()
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                return dbConexion.tipoArma.ToList();
            }
        }
        
    }
}
