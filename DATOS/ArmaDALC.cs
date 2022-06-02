using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DATOS
{
    public class ArmaDALC
    {
        public void AgregarArma(arma arm)
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                bdConexion.arma.Add(arm);
                bdConexion.SaveChanges();
            }
        }

        public List<arma> ListarArmas()
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                var armas = bdConexion.arma.Include(a => a.tipoArma).Include(a => a.marca);
                return armas.ToList();
            }
        }

        public arma GetArma(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                //return dbConexion.arma.Find(id);
                return dbConexion.arma.Where(a => a.id_arma == id).FirstOrDefault();
            }
        }

        public void EditarArma(arma arm)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var a = dbConexion.arma.Find(arm.id_arma);
                a.nombre = arm.nombre;
                a.peso = arm.peso;
                a.cantidadMunicion = arm.cantidadMunicion;
                a.IdTipoArma_Fk = arm.IdTipoArma_Fk;
                a.id_arma = arm.id_arma;
                dbConexion.SaveChanges();
            }
        }

        public void EliminarArma(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var arm = dbConexion.arma.Find(id);
                dbConexion.arma.Remove(arm);
                dbConexion.SaveChanges();
            }
            
        }
    }
}
