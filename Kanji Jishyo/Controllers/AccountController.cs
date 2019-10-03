using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanji_Jishyo.Controllers
{
    public class AccountController : Controller
    {
        // GET: LogIn
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult Join()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            return View();
        }
    }
}