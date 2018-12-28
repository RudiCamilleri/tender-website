using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TenderWebsite.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}