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
    public class SoldadoController : Controller
    {
        
        // GET: Arma
        public ActionResult Index()
        {
            var soldad = SoldadoCN.ListarSoldados();
            return View(soldad);
        }

        public ActionResult Crear()
        {

            ViewBag.IdProfesion_FK = new SelectList(ProfesionCN.GetSelectProfesion(), "id_profesion", "nombre");
            ViewBag.IdPais_Fk = new SelectList(PaisCN.GetSelectPais(), "id_pais", "nombre");
            ViewBag.IdRango_Fk = new SelectList(RangoCN.GetSelectRango(), "id", "nombre");

            return View();
        }

        [HttpPost]
        public ActionResult Crear(soldado soldad)
        {
            try
            {
                //if (arm.nombre == null)
                SoldadoCN.AgregarSoldado(soldad);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al crear un soldado");
                return View(soldad);
            }

        }

        public ActionResult GetSoldado(int id)
        {
            var soldad = SoldadoCN.GetSoldado(id);
            return View(soldad);
        }

        public ActionResult Editar(int id)
        {
            ViewBag.IdProfesion_FK = new SelectList(ProfesionCN.GetSelectProfesion(), "id_profesion", "nombre");
            ViewBag.IdPais_Fk = new SelectList(PaisCN.GetSelectPais(), "id_pais", "nombre");
            ViewBag.IdRango_Fk = new SelectList(RangoCN.GetSelectRango(), "id", "nombre");

            var soldad = SoldadoCN.GetSoldado(id);
            return View(soldad);
        }

        [HttpPost]
        public ActionResult Editar(soldado soldad)
        {
            try
            {
                SoldadoCN.Editar(soldad);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar un soldado");
                return View(soldad);
            }
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var soldad = SoldadoCN.GetSoldado(id.Value);
            return View(soldad);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                SoldadoCN.EliminarSoldado(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al elimnar el soldado");
                return View();
            }
        }
    }
}