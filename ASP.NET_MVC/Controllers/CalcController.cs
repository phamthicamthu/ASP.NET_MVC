using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class CalcController : Controller
    {
        //
        // GET: /Calc/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int x, int y, string @operator)
        {
            switch (@operator)
            {
                case "+":
                    {
                        int s = x + y;
                        ViewBag.RET = s;
                        break;
                    }
                case "-":
                    {
                        int s = x - y;
                        ViewBag.RET = s;
                        break;
                    }
                case "*":
                    {
                        int s = x * y;
                        ViewBag.RET = s;
                        break;
                    }
                default:
                    break;
            }

            return View();
        }
    }
}
