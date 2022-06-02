using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class ArmaCN
    {
        private static ArmaDALC obj = new ArmaDALC();

        public static void AgregarArma(arma arm)
        {
            obj.AgregarArma(arm);
        }

        public static List<arma> ListarArmas()
        {
            return obj.ListarArmas();
        }

        public static arma GetArma(int id)
        {
            return obj.GetArma(id);
        }

        public static void Editar(arma arm)
        {
            obj.EditarArma(arm);
        }
        public static void EliminarArma(int id)
        {
            obj.EliminarArma(id);
        }
    }
}
