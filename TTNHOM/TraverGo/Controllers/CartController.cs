using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TraverGo.Models.DB;
namespace TraverGo.Controllers
{
    public class CartController : Controller
    {
        DBContextTour db = new DBContextTour();
        public void AddItemToCast(string idDT, string idCart)
        {
            var tour = db.DestinationTours.Find(idDT);
            var cart = db.Carts.Find(idCart);
            DetailCart product = new DetailCart();
            if (tour != null && cart != null)
            {
                product.cartID = idCart;
                product.desTourID = idDT;
                if (product.sl == null)
                    product.sl = 0;
                product.sl = product.sl + 1;
                product.dayADD = DateTime.Now;
                //them vào db
                try
                {
                    var DC = db.DetailCarts.Find(idCart, idDT);
                    if (DC != null)
                    {
                        DC.sl = DC.sl + 1;
                        DC.dayADD = DateTime.Now;
                    }
                    else
                    {
                        db.DetailCarts.Attach(product);
                        db.DetailCarts.Add(product);
                    }
                    db.SaveChanges();
                }
                catch
                {

                }
                // them vào section
                var cartS = (List<DetailCart>)Session["CartSession"];
                if (cartS != null)
                {
                    cartS.Add(product);
                    //Gán vào session
                    Session["CartSession"] = cartS;
                }
                else
                {
                    //tạo mới đối tượng cart item
                    cartS = new List<DetailCart>();
                    cartS.Add(product);
                    //Gán vào session
                    Session["CartSession"] = cartS;
                }

            }
        }
        [HttpGet]
        public ActionResult RemoveOneProduct(string idDT, string idCart)
        {
            DetailCart product = db.DetailCarts.Find(idCart, idDT);
            var cartS = (List<DetailCart>)Session["CartSession"];
            if (cartS != null && cartS.Count() > 0)
                cartS.Remove(product);
            if (product != null)
            {
                try
                {
                    db.DetailCarts.Attach(product);
                    db.DetailCarts.Remove(product);
                    db.SaveChanges();
                }
                catch
                {

                }
                //

            }
            var model = new List<VIEW_detailCart>();
            if (AccountController.username != null)
                model = db.Database.SqlQuery<VIEW_detailCart>("select * from VIEW_detailCart where username = '" + AccountController.username + "'").ToList();
            else
                return RedirectToAction("Login", "Account");
            return PartialView("_PartialPage_CartProduct", model);
        }
        [HttpGet]
        public ActionResult RemoveAllProduct(string idCart)
        {
            List<DetailCart> product = db.DetailCarts.Where(x => x.cartID == idCart).ToList();
            foreach (DetailCart item in product)
            {
                var cartS = (List<DetailCart>)Session["CartSession"];
                if (cartS != null && cartS.Count() > 0)
                    cartS.Remove(item);
            }
            if (product != null)
            {
                try
                {
                    foreach (DetailCart item in product)
                    {
                        db.DetailCarts.Attach(item);
                        db.DetailCarts.Remove(item);
                    }
                    db.SaveChanges();
                }
                catch
                {

                }
                //

            }
            var model = new List<VIEW_detailCart>();
            if (AccountController.username != null)
                model = db.Database.SqlQuery<VIEW_detailCart>("select * from VIEW_detailCart where username = '" + AccountController.username + "'").ToList();
            else
                return RedirectToAction("Login", "Account");
            return PartialView("_PartialPage_CartProduct", model);
        }
    
        [HttpPost]
        public void UpdateCart(List<VIEW_detailCart> VIEW_detailCarts)
        {
            DetailCart dCart = new DetailCart();
            foreach(VIEW_detailCart it in VIEW_detailCarts)
            {
                dCart = db.DetailCarts.Find(it.cartID,it.maDD);
                dCart.sl = it.sl;
                db.SaveChanges();
            }
        }

        [HttpPost]
        public JsonResult Payment(List<VIEW_detailCart> detailCarts)
        {
            var modelList = detailCarts.ToArray();
            
            return Json(modelList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult PaymentShow()
        {
            return PartialView("_PartialPage_PaymentModal");
        }

        [HttpPost]
        public void AcceptPayment(List<VIEW_detailCart> Data)
        {
            DetailCart dCart = new DetailCart();
            foreach (VIEW_detailCart it in Data)
            {
                dCart = db.DetailCarts.Find(it.cartID, it.maDD);
                db.DetailCarts.Remove(dCart);
                db.SaveChanges();
            }
            //var model = db.Database.SqlQuery<VIEW_detailCart>("select * from VIEW_detailCart where username = '" + AccountController.username + "'").ToList();
            //return View("Cart",model);
        }
    }
}