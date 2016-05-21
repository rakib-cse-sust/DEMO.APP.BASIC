using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO.APP.BASIC.Controllers
{
    public class AccountController : Controller
    {
        // GET: LoginRegister
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(FormCollection fc)
        {
            return RedirectToAction("Index", "Dashboard");
        }

        public ActionResult Signout()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}