using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeTo.Controllers
{
    public class CuisineController : Controller
    {

        //[Authorize]
        public ActionResult Search(string name = "Brazilian")
        {
            throw new Exception("Something Wrong");

            var message = Server.HtmlDecode(name);

            return Content(message);
        }

       
    }
}