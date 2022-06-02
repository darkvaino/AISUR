using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class VehiculoCN
    {
        private static VehiculoDALC obj = new VehiculoDALC();

        public static void AgregarVehiculo(vehiculo vehic)
        {
            obj.AgregarVehiculo(vehic);
        }

        public static List<vehiculo> ListarVehiculos()
        {
            return obj.ListarVehiculos();
        }

        public static vehiculo GetVehiculo(int id)
        {
            return obj.GetVehiculo(id);
        }

        public static void Editar(vehiculo vehic)
        {
            obj.EditarVehiculo(vehic);
        }
        public static void EliminarVehiculo(int id)
        {
            obj.EliminarVehiculo(id);
        }

    }
}
