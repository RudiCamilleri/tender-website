using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TenderWebsite.Controllers
{
    public class ExtensionsController : Controller
    {
        [HttpGet]
        public ActionResult List()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                // throw custom exception and return to previous page
            }

            // get details of extension id

            return View();
        }

        //[HttpGet]
        //public ActionResult Add()
        //{
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(int? orderId) // extension details go here
        {
            if (orderId == null)
            {
                // throw custom exception and return to previous page
            }

            return RedirectToAction("Details"); // add new request id here
        }
    }
}