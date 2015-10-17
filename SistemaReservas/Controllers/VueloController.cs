using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaReservas.Entidades;
using SistemaReservas.LogicaNegocio.Interfaces;
using SistemaReservas.LogicaNegocio;

namespace SistemaReservas.Controllers
{
    public class VueloController : Controller
    {
         IVueloLN vueloLN;

        // GET: /Cliente/
        public VueloController()
        {
            vueloLN = new VueloLN();
        }
        public VueloController(IVueloLN logica)
        {
            vueloLN = logica;
        }
        //
        // GET: /Vuelo/

        public ActionResult Index()
        {
            var vuelos = vueloLN.LeerTodos();
            return View(vuelos);
         
        }

        //
        // GET: /Vuelo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vuelo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Vuelo/Create

        [HttpPost]
        public ActionResult Create(Vuelo vuelo)
        {
            if (!ModelState.IsValid)
                return View(vuelo);
            vueloLN.Insertar(vuelo);
            return RedirectToAction("Index");
        }

        //
        // GET: /Vuelo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vuelo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vuelo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vuelo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
