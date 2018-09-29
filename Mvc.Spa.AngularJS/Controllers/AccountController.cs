using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Spa.AngularJS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Home
        public ActionResult Login()
        {
            return View("Index");
        }
    }
}