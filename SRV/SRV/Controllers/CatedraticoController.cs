using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.Controllers
{
    public class CatedraticoController : Controller
    {
        // GET: Catedratico
        public ActionResult Index()
        {
            return View();
        }

        // GET: Catedratico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catedratico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catedratico/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catedratico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catedratico/Edit/5
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

        // GET: Catedratico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catedratico/Delete/5
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
