using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using System.Data.Entity;

namespace DATOS
{
    public class SoldadoDALC
    {
        public void AgregarSoldado(soldado soldad)
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                bdConexion.soldado.Add(soldad);
                bdConexion.SaveChanges();
            }
        }

        public List<soldado> ListarSoldados()
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                var soldados = bdConexion.soldado.Include(s => s.pais).Include(s => s.profesion).Include(s => s.rango);
                return soldados.ToList();
            }
        }

        public  soldado GetSoldado(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                //return dbConexion.arma.Find(id);
                return dbConexion.soldado.Where(s => s.id_soldado == id).FirstOrDefault();
            }
        }

        public void EditarSoldado(soldado soldad)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
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
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var soldad = dbConexion.soldado.Find(id);
                dbConexion.soldado.Remove(soldad);
                dbConexion.SaveChanges();
            }

        }
    }
}
