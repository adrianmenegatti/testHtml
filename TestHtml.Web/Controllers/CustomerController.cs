using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestHtml.Web.Controllers
{
    using Core.Entities;

    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCustomers()
        {
            var customer = new Customer
            {
                CompanyName = "CompanyName",
                ContactName = "ContactName",
                Country = "Country"
            };

            return Json(customer, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PostCustomer(Customer customer)
        {
            return null;
        }
	}
}