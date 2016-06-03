using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class GreetingsController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Details(string Name, string CompanyName)
        {
            ViewData["cName"] = Name;
            ViewData["cCompany"] = CompanyName;
            return View("showDetails");
        }

        public ActionResult showDetails() {
            return View();
        }



    }
}