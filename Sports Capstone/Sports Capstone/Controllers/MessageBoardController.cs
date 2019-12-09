using Microsoft.AspNet.Identity;
using Sports_Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

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
            try
            {
                //var ApplicationId = User.Identity.GetUserId();
                //Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
                //Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
                //PlayingEvent playingEvent = context.PlayingEvents.Where(p => p.Id == playingEvent.)
                var message = context.MessageBoards.ToList();
                return View(message);
            }
            catch
            {
                return View();
            }

        }

        // GET: MessageBoard/Details/5
        public ActionResult Details(int? id)
        {
            var messages = context.MessageBoards.Where(m => m.Id == id).FirstOrDefault();
            return View(messages);
        }

        // GET: MessageBoard/Create
        public ActionResult Create()
        {

            MessageBoard message = new MessageBoard();

            return View(message);
        }

        // POST: MessageBoard/Create
        [HttpPost]
        public ActionResult Create(MessageBoard message)
        {
            try
            {
                // TODO: Add insert logic here
                var ApplicationId = User.Identity.GetUserId();
                Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
                message.PlayingEventId = player.PlayingEventId;

                context.MessageBoards.Add(message);
                context.SaveChanges();
                
                return RedirectToAction("Details",new { id = message.Id});
            }
            catch
            {
                return View(message);
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
