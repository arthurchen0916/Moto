using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moto.Core;
using Moto.Common.Entities;
using Moto.Common.Models;

namespace Moto.MVC.Controllers
{
    public class MotoSearchController : Controller
    {
        BrandService brandService = new BrandService();
        ModelService modelService = new ModelService();

        // GET: MotoSearch
        public ActionResult Index()
        {
            InitBag();
            IEnumerable<Model> model = new List<Model>();
            return View(model);

        }

        public ActionResult Query(MotoSearch parm)
        {
            InitBag();
            var model = modelService.Query(parm).ToList();
            return View("Index", model);
        }

        private void InitBag()
        {
            var brand = brandService.GetAll().Select(x =>
                                            new SelectListItem()
                                            {
                                                Text = x.Brand_name.ToString(),
                                                Value = x.Brand_code.ToString()
                                            }).ToList();

            brand.Insert(0, (new SelectListItem { Text = "ALL", Value = "" }));
            ViewBag.Brand_code = brand;

            var year = modelService.GetYear().Select(y =>
                                            new SelectListItem()
                                            {
                                                Text = y.ToString(),
                                                Value = y.ToString()
                                            }).ToList();
            year.Insert(0, (new SelectListItem { Text = "ALL", Value = "" }));
            ViewBag.Year = year;
        }

    }
}