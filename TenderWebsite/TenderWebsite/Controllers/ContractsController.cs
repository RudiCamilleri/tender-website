using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TenderWebsite.Controllers
{
    public class ContractsController : Controller
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

            // get details of contract id

            return View();
        }
    }
}