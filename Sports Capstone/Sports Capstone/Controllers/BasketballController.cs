using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_Capstone.Controllers
{
    public class BasketballController : Controller
    {
        // GET: Basketball
        public ActionResult Index()
        {
            return View();
        }

        // GET: Basketball/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Basketball/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Basketball/Create
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

        // GET: Basketball/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Basketball/Edit/5
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

        // GET: Basketball/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Basketball/Delete/5
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
