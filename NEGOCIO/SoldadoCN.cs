using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
   public class SoldadoCN
    {

        private static SoldadoDALC obj = new SoldadoDALC();

        public static void AgregarSoldado(soldado soldad)
        {
            obj.AgregarSoldado(soldad);
        }

        public static List<soldado> ListarSoldados()
        {
            return obj.ListarSoldados();
        }

        public static soldado GetSoldado(int id)
        {
            return obj.GetSoldado(id);
        }

        public static void Editar(soldado soldad)
        {
            obj.EditarSoldado(soldad);
        }
        public static void EliminarSoldado(int id)
        {
            obj.EliminarSoldado(id);
        }

    }
}
