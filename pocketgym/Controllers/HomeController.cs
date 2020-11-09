using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pocketgym.Models;
using System.Security.Cryptography;
namespace pocketgym.Controllers
{
    public class HomeController : Controller
    {
        private DB_Entities _db = new DB_Entities();
        // GET: Home
        public ActionResult Index()
        {
            if (Session["idUser"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (ModelState.IsValid)
            {

                var data = _db.Users.Where(s => s.Email.Equals(email) && s.Password.Equals(password)).ToList();
                if (data.Count() > 0)
                {
                    return RedirectToAction("Workout");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Register");
                }
            }
            return View();
        }

    }
}