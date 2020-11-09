using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pocketgym.Models;

namespace pocketgym.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Register(int id = 0)
        {
            UserInfo userModel = new UserInfo();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult Register(UserInfo userModel)
        {
            using (PocketGymsEntities fullModel = new PocketGymsEntities())
            {
                if (fullModel.UserInfoes.Any(x => x.Username == userModel.Username))
                {
                    ViewBag.DuplicateMessage = "Username already exist";
                    return View("Register", userModel);
                }

                fullModel.UserInfoes.Add(userModel);
                fullModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful!";
            return View("Register", new UserInfo());
        }
    }
}