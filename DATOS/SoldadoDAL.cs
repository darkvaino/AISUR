using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
    public class SoldadoDAL
    {
        public void AgregarSoldado(soldado soldad)
        {
            using (var bdConexion = new bdaisurEntities())
            {
                bdConexion.soldado.Add(soldad);
                bdConexion.SaveChanges();
            }
        }

        public List<soldado> ListarSoldados()
        {
            using (var bdConexion = new bdaisurEntities())
            {
                return bdConexion.soldado.ToList();
            }
        }

        public  soldado GetSoldado(int id)
        {
            using (var dbConexion = new bdaisurEntities())
            {
                //return dbConexion.arma.Find(id);
                return dbConexion.soldado.Where(s => s.id_soldado == id).FirstOrDefault();
            }
        }

        public void EditarSoldado(soldado soldad)
        {
            using (var dbConexion = new bdaisurEntities())
            {
                var p = dbConexion.soldado.Find(soldad.id_soldado);
                p.edad= soldad.edad;
                p.experiencia = soldad.experiencia;
                p.capacidadCarga = soldad.capacidadCarga;
                p.idPais_Fk = soldad.idPais_Fk;
                p.idProfesion_Fk = soldad.idProfesion_Fk;
                p.idRango_Fk = soldad.idRango_Fk;
                dbConexion.SaveChanges();
            }
        }

        public void EliminarSoldado(int id)
        {
            using (var dbConexion = new bdaisurEntities())
            {
                var soldad = dbConexion.soldado.Find(id);
                dbConexion.soldado.Remove(soldad);
                dbConexion.SaveChanges();
            }

        }
    }
}
