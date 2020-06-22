using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverGo.Models.DB;
namespace TraverGo.Controllers
{
    public class DestinationController : Controller
    {
        DBContextTour db = new DBContextTour();


        [HttpGet]
        public ActionResult Get9product(string page)
        {
            int pageI = Int32.Parse(page);
            var model = db.DestinationTours.OrderBy(x => x.maDD).Skip((pageI - 1) * 9).Take(9).ToList();
            return PartialView("_PartialPage_9product", model);
        }
        [HttpGet]
        public ActionResult SearchProduct(string key1, string key2, string key3)
        {
            var model = db.DestinationTours.SqlQuery("select * from DestinationTour " +
                "where tenDD like N'%" + key1 + "%' and tenQG like N'%" + key2 + "%' and tenTinh like N'%" + key3 + "%'");
            ViewBag.countRE = model.ToList().Count() / 9 + 1;
            var modelRe = model.Take(9).ToList();
            return PartialView("_PartialPage_ResultSearch", modelRe);
        }

        [HttpGet]
        public ActionResult DetailProduct(string id)
        {
            var model = db.DestinationTours.Find(id);
            return PartialView("_PartialPage_ModalProduct", model);
        }
    }
}