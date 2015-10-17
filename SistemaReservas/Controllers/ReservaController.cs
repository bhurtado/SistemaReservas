using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaReservas.Entidades;
using SistemaReservas.LogicaNegocio.Interfaces;
using SistemaReservas.LogicaNegocio;
using SistemaReservas.Models;

namespace SistemaReservas.Controllers
{
    public class ReservaController : Controller
    {
         IReservaLN reservaLN;

        // GET: /Cliente/
        public ReservaController()
        {
            reservaLN = new ReservaLN();
        }
        public ReservaController(IReservaLN logica)
        {
            reservaLN = logica;
        }

        //
        // GET: /Reserva/

        public ActionResult Index()
        {
            var reservas = reservaLN.LeerTodos();

            return View(reservas);
        }

        //
        // GET: /Reserva/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reserva/Create

        public ActionResult Create()
        {
            ReservaViewModel oReservaViewModel = new ReservaViewModel();
            oReservaViewModel.Reserva = new Reserva();
            oReservaViewModel.Clientes = (new ClienteLN()).LeerTodos();
            oReservaViewModel.Vuelos = (new VueloLN()).LeerTodos();
            return View(oReservaViewModel);
        }

        //
        // POST: /Reserva/Create

        [HttpPost]
        public ActionResult Create(Reserva reserva)
        {
            reservaLN.Insertar(reserva);
            return null;
        }

        //
        // GET: /Reserva/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reserva/Edit/5

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
        // GET: /Reserva/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reserva/Delete/5

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
