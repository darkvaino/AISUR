using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DATOS
{
    public class MarcaDALC
    {
        public IEnumerable<marca> marcaArma;
        //listarel nombre marca en el select de la foranea de arma
        public List<marca> GetSelectMarca(bool esArma)
        {
            using (var dbConexion = new dbconflictoaisurEntities())
            {
                if (esArma)
                {
                    marcaArma = dbConexion.marca.ToList().Where(m => m.nombre.Contains("Arma"));
                    return marcaArma.ToList();
                }
                marcaArma = dbConexion.marca.ToList().Where(m => m.nombre.Contains("Vehiculo"));
                return marcaArma.ToList();
            }
        }

        //agregar nueva marca
        public void AgregarMarca(marca marca)
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                bdConexion.marca.Add(marca);
                bdConexion.SaveChanges();
            }
        }

        //listar todos los nombres de marca

        public List<marca> ListarMarcas()
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                return bdConexion.marca.ToList();
            }
        }

    }
}
