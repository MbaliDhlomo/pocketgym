using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pocketgym.Controllers
{
    public class UserWorkoutController : Controller
    {
        // GET: UserWorkout
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserWorkout/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserWorkout/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserWorkout/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserWorkout/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserWorkout/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserWorkout/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserWorkout/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
