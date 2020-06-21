using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraverGo.Models.DB;

namespace TraverGo.Controllers
{
    public class AccountController : Controller
    {
        string lastAcc = null;
        DBContextTour db = new DBContextTour();
        static public string username = null;
        // GET: Account
        public ActionResult Login()
        {
            ViewBag.username = lastAcc;
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Logout()
        {
            username = null;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public JsonResult CheckAccount(string user, string pass)
        {
            var acc = db.Customers.Find(user);
            var quyen = acc.nameQ;
            if (acc != null)
            {
                if (pass.Equals(acc.pass))
                {
                    username = user;
                    if (quyen != "Admin")
                    {
                        return Json(new { mes = 1 }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(new { mes = 4 }, JsonRequestBehavior.AllowGet);
                    }
                }
                else
                {
                    return Json(new { mes = 2 }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { mes = 3 }, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public JsonResult RegisAccount(Customer data)
        {
            if (data != null)
            {
                var cus = db.Customers.Find(data.username);
                if (cus == null && data != null)
                {
                    db.Customers.Attach(data);
                    db.Customers.Add(data);
                    db.SaveChanges();
                    return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
        }
    }
}