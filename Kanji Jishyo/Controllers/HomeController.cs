using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanji_Jishyo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomePage()
        {
            ViewBag.Message = "Домашняя страница";

            return View();
        }
    }
}