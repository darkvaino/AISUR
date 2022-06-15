using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DATOS
{
    public class VehiculoDALC
    {

        public void AgregarVehiculo(vehiculo vehic)
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                bdConexion.vehiculo.Add(vehic);
                bdConexion.SaveChanges();
            }
        }

        public List<vehiculo> ListarVehiculos()
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                var armas = bdConexion.vehiculo.Include(tv => tv.tipoVehiculo).Include(tv => tv.marca);
                return armas.ToList();
            }
        }

        public vehiculo GetVehiculo(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                //return dbConexion.arma.Find(id);
                return dbConexion.vehiculo.Where(v => v.id_vehiculo == id).FirstOrDefault();
            }
        }

        public void EditarVehiculo(vehiculo vehic)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var v = dbConexion.vehiculo.Find(vehic.id_vehiculo);
                v.nombre = vehic.nombre;
                v.cilindraje = vehic.cilindraje;
                v.capacidadCargaMunicion = vehic.capacidadCargaMunicion;
                v.idTipoVehiculo_Fk = vehic.idTipoVehiculo_Fk;
                v.idMarca_Fk = vehic.idMarca_Fk;
                dbConexion.SaveChanges();
            }
        }

        public void EliminarVehiculo(int id)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                var vehic = dbConexion.vehiculo.Find(id);
                dbConexion.vehiculo.Remove(vehic);
                dbConexion.SaveChanges();
            }

        }

    }
}
