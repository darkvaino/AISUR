using ENTIDAD;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoASW.Controllers
{
    public class ArmaController : Controller
    {
        // GET: Arma
        public ActionResult Index()
        {
            var arm = ArmaCN.ListarArmas();
            return View(arm);
        }
        
        public ActionResult Crear()
        {
            ViewBag.IdMarca_Fk = new SelectList(MarcaCN.GetSelectMarca(true), "id_marca", "nombre");
            ViewBag.IdTipoArma_Fk = new SelectList(TipoArmaCN.GetSelectTipoArma(), "id_tipoArma", "nombre");
            return View();
        }

        [HttpPost]
        public ActionResult Crear(arma arm)
        {
            try
            {
                //if (arm.nombre == null)
                ArmaCN.AgregarArma(arm);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al crear un arma");
                return View(arm);
            }
            
        }

        public ActionResult GetArma(int id)
        {
            var arm = ArmaCN.GetArma(id);
            return View(arm);
        }

        public ActionResult Editar(int id)
        {
            ViewBag.IdMarca_Fk = new SelectList(MarcaCN.GetSelectMarca(true), "id_marca", "nombre");
            ViewBag.IdTipoArma_Fk = new SelectList(TipoArmaCN.GetSelectTipoArma(), "id_tipoArma", "nombre");
            var arm = ArmaCN.GetArma(id);
            return View(arm);
        }

        [HttpPost]
        public ActionResult Editar(arma arm)
        {
            try
            {
                ArmaCN.Editar(arm);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar un arma");
                return View(arm);
            }
        }
               
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var arm = ArmaCN.GetArma(id.Value);
            return View(arm);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                ArmaCN.EliminarArma(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al elimnar el arma");
                return View();
            }
        }
    }    
}