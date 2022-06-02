using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProyectoASW.Controllers
{
    public class UsuarioController : Controller
    {

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Usuario model, string returnUrl)
        {
            bool islogin = false;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                islogin = UsuarioCN.verifyLogin(model);
            }
            catch (Exception ex)
            {

               return View(ex.Message);
            }
           

            if (islogin)
            {
                Session["UsuarioRegistrado"] = model.Login;
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Intento de inicio de sesión no válido.");
                return RedirectToAction("Login", "Account");
            }
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(Usuario model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            UsuarioCN.registerUser(model);

            return RedirectToAction("Login", "Account");


        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return RedirectToAction("Index", "Arma");
            }
            return RedirectToAction("Index", "Home");
        }

    }
}