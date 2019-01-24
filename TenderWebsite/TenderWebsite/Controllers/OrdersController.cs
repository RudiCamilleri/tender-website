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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int? amount) // order details go here
        {
            //Guid newOrderId = Guid.NewGuid();
            // update number of s, m, l servers being ordered
            // set order creation time to now
            // set deadline time to now + delivery time
            // set on hold time to 0
            // set cost to total cost
            // add order record

            return RedirectToAction("Details"); // add new request id here
        }
    }
}