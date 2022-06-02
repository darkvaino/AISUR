using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ProfesionDALC
    {

       

        public void AgregarProfesion(profesion profesn)
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                bdConexion.profesion.Add(profesn);
                bdConexion.SaveChanges();
            }
        }



        public List<profesion> GetSelectProfesion()
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                return dbConexion.profesion.ToList();
            }
        }

        public List<profesion> ListarProfesion()
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                return bdConexion.profesion.ToList();
            }
        }

        public profesion GetProfesion(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                //return dbConexion.arma.Find(id);
                return dbConexion.profesion.Where(p => p.id_profesion == id).FirstOrDefault();
            }
        }

        public void EditarProfesion(profesion profesn)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var p = dbConexion.profesion.Find(profesn.id_profesion);
                p.nombre = profesn.nombre;                               
                dbConexion.SaveChanges();
            }
        }

        public void EliminarProfesion(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var profesn = dbConexion.profesion.Find(id);
                dbConexion.profesion.Remove(profesn);
                dbConexion.SaveChanges();
            }

        }
    }
}
