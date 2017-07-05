using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeTo.Models;
namespace OdeTo.Controllers
{
    public class HomeController : Controller
    {
        OdeToDb _db = new OdeToDb();
        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Fabio Vinicius";
            model.Location = "São Paulo - SP";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}