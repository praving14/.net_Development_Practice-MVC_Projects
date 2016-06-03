using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Customer c) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(c);
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}