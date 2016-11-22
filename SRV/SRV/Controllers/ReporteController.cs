using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRV.Controllers
{
    public class ReporteController : Controller
    {
        //
        // GET: /Reporte/
      public ActionResult Index()
      {
        return View();
      }

      public ActionResult Catedratico()
      {
        return View();
      }

      public ActionResult Materia()
      {
        return View();
      }
	}
}