using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverGo.Models.DB;

namespace TraverGo.Controllers
{
    public class HomeController : Controller
    {

        private DBContextTour context = new DBContextTour();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.acc = context.Customers.Find(AccountController.username);
            ViewBag.top4Nation = context.VIEW_top4Nation.Take(4).ToList();
            ViewBag.Cart = context.Carts.Where(x => x.username == AccountController.username).ToList();
            ViewBag.top6DT = context.DestinationTours.OrderBy(x => x.countTour).Take(6).ToList();
            ViewBag.FeedBack = context.Customers.Where(x => x.nameQ != "Admin").Take(5).ToList();
            ViewBag.top3Blog = context.detailBlogs.Take(3).ToList();
            return View();
            //return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Destination()
        {
            ViewBag.Cart = context.Carts.Where(x => x.username == AccountController.username).ToList();
            ViewBag.countPageP = (context.DestinationTours.OrderBy(x => x.maDD).Where(x => x.maDD != null).ToList().Count()) / 9 + 1;
            ViewBag.top4Nation = context.VIEW_top4Nation.Take(4).ToList();
            var model = context.DestinationTours.Take(9).ToList();
            return View(model);
            // return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Cart()
        {
            if (AccountController.username == null || AccountController.username == "")
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                // gán cart = section hiện tại
                var model = new List<VIEW_detailCart>();
                if (AccountController.username != null)
                {
                    model = context.Database.SqlQuery<VIEW_detailCart>("select * from VIEW_detailCart where username = '" + AccountController.username + "'").ToList();
                }
                var cart = (List<DetailCart>)Session["CartSession"];
                // nếu trống thì tao mới
                if (cart == null)
                {
                    cart = new List<DetailCart>();
                }

                return View(model);
            }
        }
    }
}