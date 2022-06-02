using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
    public class ProfesionCN
    {

        private static ProfesionDALC obj = new ProfesionDALC();

        public static void AgregarProfesion(profesion profesn)
        {
            obj.AgregarProfesion(profesn);
        }


        //listar todas las profesiones en el campo de la foranea de soldado
        public static List<profesion> GetSelectProfesion()
        {
            return obj.GetSelectProfesion();
        }


        public static List<profesion> ListarProfesion()
        {
            return obj.ListarProfesion();
        }

        public static profesion GetProfesion(int id)
        {
            return obj.GetProfesion(id);
        }

        public static void Editar(profesion profesn)
        {
            obj.EditarProfesion(profesn);
        }
        public static void EliminarProfesion(int id)
        {
            obj.EliminarProfesion(id);
        }
    }
}
