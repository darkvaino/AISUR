using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DATOS
{
    public class UsuarioDALC
    {

        public bool verifyLogin(Usuario user) {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                var usuarios = bdConexion.Usuario.ToList();
                Usuario usuarioEntity = bdConexion.Usuario.Where(x => x.Password == user.Password && x.Login == user.Login).FirstOrDefault();
                return usuarioEntity == null ? false : true;
            }
        }

        public void registerUser(Usuario user) 
        {
            using (var bdConexion = new dbconflictoaisurEntities())
            {
                var usuarios = bdConexion.TipoUsuario.ToList();
                TipoUsuario tip = new TipoUsuario();
                tip.id_TipoUsuario = 1;
                tip.Nombre = "Admin";
                bdConexion.TipoUsuario.Add(tip);
                bdConexion.Usuario.Add(user);
                bdConexion.SaveChanges();
            }
        }
    }
}
