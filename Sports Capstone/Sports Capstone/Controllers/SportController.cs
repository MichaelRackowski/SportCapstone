using Microsoft.AspNet.Identity;
using Sports_Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_Capstone.Controllers
{
    public class SportController : Controller
    {
        //public ActionResult Sort(int? id)
        //{
        //    var sport;
        //    switch (sport)
        //    {
        //        case Basketball:

        //    }
        //}
       
        
            public ApplicationDbContext context;

            public SportController()
            {
                context = new ApplicationDbContext();

            }

            // GET: Sport
            public ActionResult Index()
            {
            var sports = context.Sports.ToList();
            return View();
            }

        //GET: Sport/Details/5
        public ActionResult Details(int? id)
        {
            Sport sport = context.Sports.FirstOrDefault(s => s.Id == id);
            
            return View(sport);
        }

        // GET: Sport/Create
        public ActionResult Create()
        {
            Sport sport = new Sport();
            sport.TypeOfPlay = " Casual or Competetive ".ToLower();
            sport.SportName = "Soccer,Basketball,Golf".ToLower();
            sport.SkillLevel = "Beginner,Average,Expert".ToLower();
            return View(sport);
        }

        // POST: Sport/Create
        [HttpPost]
        public ActionResult Create(Sport sport)
        {
            try
            {
                /// get current user and assign them to CurrentPlayer
                var ApplicationId = User.Identity.GetUserId();
                Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
                sport.PlayerId = player.Id;

                context.Sports.Add(sport);
                context.SaveChanges();

                return RedirectToAction("Details",new { id = sport.Id });
            }
            catch
            {
                return View(sport);
            }
        }

        // GET: Sport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sport/Edit/5
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

        // GET: Sport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sport/Delete/5
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
