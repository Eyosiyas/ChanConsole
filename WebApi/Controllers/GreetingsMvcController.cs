using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;

namespace WebApi.Controllers
{
    public class GreetingsMvcController : Controller
    {
        // GET: GreetingsMvc
        public ActionResult Index()
        {
            return Json(new Greeting().Greet(), JsonRequestBehavior.AllowGet);
        }
    }
}