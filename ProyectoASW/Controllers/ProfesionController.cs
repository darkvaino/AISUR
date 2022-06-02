using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using NEGOCIO;

namespace ProyectoASW.Controllers
{
    public class ProfesionController : Controller
    {
        
        // GET: Arma
        public ActionResult Index()
        {
            var profesn = ProfesionCN.ListarProfesion();
            return View(profesn);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(profesion profesn)
        {
            try
            {
                //if (arm.nombre == null)
                ProfesionCN.AgregarProfesion(profesn);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al crear una profesion");
                return View(profesn);
            }

        }

        public ActionResult GetProfesion(int id)
        {
            var profesn = ProfesionCN.GetProfesion(id);
            return View(profesn);
        }


        public ActionResult Editar(int id)
        {
            var profesn = ProfesionCN.GetProfesion(id);
            return View(profesn);
        }

        [HttpPost]
        public ActionResult Editar(profesion profesn)
        {
            try
            {
                ProfesionCN.Editar(profesn);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar una profesion");
                return View(profesn);
            }
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var profesn = ProfesionCN.GetProfesion(id.Value);
            return View(profesn);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                ProfesionCN.EliminarProfesion(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al elimnar la profesion");
                return View();
            }
        }
    }
}