using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moto.Core;
using Moto.Common.Entities;

namespace Moto.MVC.Controllers
{
    public class MotoSearchController : Controller
    {

        BrandService brandService;
        ModelService modelService;

        // GET: MotoSearch
        public ActionResult Index()
        {
            modelService = new ModelService();
            brandService = new BrandService();

            var models = brandService.GetAll().ToList();

            ViewBag.Models = models.Select(x =>
                                                      new SelectListItem()
                                                      {
                                                          Text = x.Brand_code,
                                                          Value = x.id.ToString()
                                                      });

            var yearlist = modelService.GetAll().ToList();

            ViewBag.Yearlists= yearlist.Select(x =>
                                                      new SelectListItem()
                                                      {
                                                          Text = x.Year.ToString(),
                                                          Value = x.id.ToString()
                                                      });


            return View(new List<Model>());
        }

        [HttpPost]
        public ActionResult Index(int cc)
        {
            modelService = new ModelService();
            var models = modelService.GetAll().ToList();

            ViewBag.Models = models.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.cc.ToString(),
                                      Value = x.id.ToString()
                                  }); ;

            var model = modelService.QueryByCC(cc).ToList();
            return View(model);
        }

        public ActionResult QueryByCC(int cc)
        {

            var model = modelService.QueryByCC(cc).ToList();
            return View(model);
        }

    }
}