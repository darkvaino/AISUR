using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ENTIDAD;
using NEGOCIO;

namespace ProyectoASW.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            var marcasn = MarcaCN.ListarMarca();
            return View(marcasn);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(marca marcasn)
        {
            try
            {
                //if (arm.nombre == null)
                MarcaCN.AgregarMarca(marcasn);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al crear una profesion");
                return View(marcasn);
            }

        }
    }
}