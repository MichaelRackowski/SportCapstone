using Microsoft.AspNet.Identity;
using Sports_Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_Capstone.Controllers
{
    public class PlayingEventController : Controller
    {
        public ApplicationDbContext context;

        public PlayingEventController()
        {
            context = new ApplicationDbContext();

        }

        // GET: PlayingEvent
        public ActionResult Index()
        {
            var playingevent = context.PlayingEvents.ToList();
            return View();
        }

        // GET: PlayingEvent/Details/5
        public ActionResult Details(int? id)
        {
            PlayingEvent playingEvent = context.PlayingEvents.FirstOrDefault((p => p.Id == id));

            return View(playingEvent);
        }

        // GET: PlayingEvent/Create
        public ActionResult Create()
        {
            PlayingEvent playingEvent = new PlayingEvent();
            return View(playingEvent);
        }

        // POST: PlayingEvent/Create
        [HttpPost]
        public ActionResult Create(PlayingEvent playingEvent)
        {
            try
            {
                // TODO: Add insert logic here

                var ApplicationId = User.Identity.GetUserId();
                Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
                Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
                playingEvent.SkillLevel = sport.SkillLevel;
                playingEvent.SportName = sport.SportName;
                playingEvent.TypeOfPlay = sport.TypeOfPlay;
                return RedirectToAction("Details", new { id = playingEvent.Id });
            }
            catch
            {
                return View(playingEvent);
            }
        }

        // GET: PlayingEvent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayingEvent/Edit/5
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

        // GET: PlayingEvent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayingEvent/Delete/5
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
