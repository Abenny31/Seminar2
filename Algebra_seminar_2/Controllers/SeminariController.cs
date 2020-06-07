using Algebra_seminar_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Algebra_seminar_2.Controllers
{
    public class SeminariController : Controller
    {
        private bazaDbContext _Db = new bazaDbContext();
        // GET: Seminari
        public ActionResult Popis()
        {
            return View(_Db._dboSm.ToList());
        }

        public ActionResult Predbiljezba(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                Predbiljezba aktivna = new Predbiljezba();
                aktivna.FkSeminar = (int)id;
                
                return View(aktivna);
            }
            //return View();
        }

        [HttpPost]
        public ActionResult Predbiljezba(Predbiljezba b)
        {

            if (ModelState.IsValid)
            {
                _Db._dboPb.Add(b);
                _Db.SaveChanges();
                ViewBag.uredu = "Osoba je dodana";
                return RedirectToAction("Popis");
            }
            else
            {
                ViewBag.greska = "Doslo je do pogreske";
                return View();
            }
            //return View();
        }
    }
}