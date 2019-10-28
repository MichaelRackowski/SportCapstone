using Sports_Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_Capstone.Controllers
{
    public class MessageBoardController : Controller
    {

        public ApplicationDbContext context;

        public MessageBoardController()
        {
            context = new ApplicationDbContext();

        } 

        public ActionResult Message()
        {

            return View();
        }
        // GET: MessageBoard
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageBoard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageBoard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageBoard/Create
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

        // GET: MessageBoard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageBoard/Edit/5
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

        // GET: MessageBoard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageBoard/Delete/5
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
