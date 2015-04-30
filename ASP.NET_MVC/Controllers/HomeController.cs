using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/GetID/7 or /Home/GetID?id=7

        public ActionResult GetID(int? id)
        {
            if (id.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Ret = id;
            return View();
        }

        //
        // GET: /Home/GetIDName?id=7&name=thu

        public ActionResult GetIDName(int? id, string name)
        {
            if (id.HasValue == false)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ID = id;
            ViewBag.Name = name;
            return View();
        }


    }
}
