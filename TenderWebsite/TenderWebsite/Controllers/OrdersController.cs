using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TenderWebsite.Controllers
{
    public class OrdersController : Controller
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

            // get details of order id

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add() // order details go here
        {
            return RedirectToAction("Details"); // add new request id here
        }
    }
}