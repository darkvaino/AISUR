using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class MarcaCN
    {
        private static MarcaDALC obj = new MarcaDALC();

        public static List<marca> GetSelectMarca(bool esArma)
        {
            return obj.GetSelectMarca(esArma);
        }



        public static void AgregarMarca(marca marca)
        {
            obj.AgregarMarca(marca);
        }

        //listar marca

        public static List<marca> ListarMarca()
        {
            return obj.ListarMarcas();
        }
    }
}
