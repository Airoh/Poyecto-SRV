using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;
using System.Data;
using SRV.Componentes.Acceso;

namespace SRV.Controllers
{
    public class HomeController : Controller
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public ActionResult Index()
        {
            try
            {
                ManejadorDB MDB = new ManejadorDB();
                MDB.EjecutarEscalar("");

            }
            catch (Exception e)
            {

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}