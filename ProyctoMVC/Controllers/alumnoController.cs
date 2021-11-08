using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyctoMVC.appGet;
using ProyctoMVC.Models;

namespace ProyctoMVC.Controllers
{
    public class alumnoController : Controller
    {
        // GET: alumno2
        public ActionResult Index()
        {
            gestion sg = new gestion();
            ViewBag.data = sg.mostrarEstudiante();
            return View();
        }

        // POST: alumno2/Create
        [HttpPost]
        public ActionResult Insertar(alumno es)
        {
            try
            {
                // TODO: Add insert logic here
                gestion sg = new gestion();
                sg.insertar(es);
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Insertar()
        {
 
                return View();
            
        }


        // POST: alumno2/Edit/5
        [HttpPost]
        public ActionResult modificar(alumno es)
        {
            gestion sg = new gestion();
            sg.modificar(es);
            ViewBag.data = sg.mostrarEstudiante();
            return View("Index");
        }

        public ActionResult modificar(String cod)
        {
            gestion sg = new gestion();
            ViewBag.data = sg.mostrarEstudiante2(cod);
            return View(ViewBag.data);
        }

        // POST: alumno2/Delete/5
        public ActionResult eliminar(String cod)
        {                   
            gestion sg = new gestion();
            sg.eliminar(cod);
            ViewBag.data = sg.mostrarEstudiante();
            return View("Index");
        }
    }
}
