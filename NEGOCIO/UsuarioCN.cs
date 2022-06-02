using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDAD;

namespace NEGOCIO
{
    public class UsuarioCN
    {
        private static UsuarioDALC usuarioDALC = new UsuarioDALC();

        public static bool verifyLogin(Usuario user)
        {
            return usuarioDALC.verifyLogin(user);
        }

        public static void registerUser(Usuario user)
        {
            usuarioDALC.registerUser(user);
        }


    }
}
