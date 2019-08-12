using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moto.Core;
using Moto.Common.Entities;
using Moto.Common.Models;
using Moto.MVC.Models;

namespace Moto.MVC.Controllers
{
    public class TransactionRecordController : Controller
    {
        TransactionService transactionService = new TransactionService();

        // GET: TransactionManagement
        public ActionResult Index()
        {
            IEnumerable<Transaction> model = new List<Transaction>();
            return View(model);

        }

        public ActionResult Query(TransactionRecord p)
        {
            var model = transactionService.Query(p).ToList();
            return View("Index", model);
        }

    }
}