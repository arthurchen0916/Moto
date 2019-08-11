using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moto.Core;
using Moto.Common.Entities;
using Moto.Common.Models;

namespace Moto.MVC.Controllers
{
    public class CustomerManagementController : Controller
    {
        CustomerService customerService = new CustomerService();

        // GET: CustomerManagement
        public ActionResult Index()
        {
            IEnumerable<Customer> model = new List<Customer>();
            return View(model);

        }

        public ActionResult Query(CustomerManagement n)
        {
            var model = customerService.Query(n).ToList();
            return View("Index", model);
        }
    }
}