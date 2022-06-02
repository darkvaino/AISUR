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
    public class VehiculoController : Controller
    {
        // GET: Vehiculo
        public ActionResult Index()
        {
            var vehic = VehiculoCN.ListarVehiculos();
            return View(vehic);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(vehiculo vehic)
        {
            try
            {
                //if (arm.nombre == null)
                VehiculoCN.AgregarVehiculo(vehic);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al crear un Vehiculo");
                return View(vehic);
            }
        }

        public ActionResult GetVehiculo(int id)
        {
            var vehic = VehiculoCN.GetVehiculo(id);
            return View(vehic);
        }

        public ActionResult Editar(int id)
        {
            var vehic = VehiculoCN.GetVehiculo(id);
            return View(vehic);
        }

        [HttpPost]
        public ActionResult Editar(vehiculo vehic)
        {
            try
            {
                VehiculoCN.Editar(vehic);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar un Vehiculo");
                return View(vehic);
            }
        }

        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var vehic = VehiculoCN.GetVehiculo(id.Value);
            return View(vehic);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {
                VehiculoCN.EliminarVehiculo(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al elimnar el Vehiculo");
                return View();
            }
        }

    }
}