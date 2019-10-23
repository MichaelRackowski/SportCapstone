using Microsoft.AspNet.Identity;
using Sports_Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sports_Capstone.Controllers
{
    public class PlayerController : Controller
    {
       public ApplicationDbContext context;

        public PlayerController()
        {
            context = new ApplicationDbContext();
           
        }
          
        // GET: Player
        public ActionResult Index()
        {
            var players = context.Players.ToList();
            return View(players);
        }

        // GET: Player/Details/5
        public ActionResult Details(int? id)
        {
            var applicationId = User.Identity.GetUserId();
            Player player = context.Players.FirstOrDefault(p => p.ApplicationId == applicationId);


            return View(player);
        }

        // GET: Player/Create
        public ActionResult Create()
        {
            Player player = new Player();
            return View(player);
        }

        // POST: Player/Create
        [HttpPost]
        public ActionResult Create(Player player )
        {
            if (ModelState.IsValid)
            {
                player.ApplicationId = User.Identity.GetUserId();
                context.Players.Add(player);
                context.SaveChanges();
                return RedirectToAction("Details");
            }           
                return View(player);
            
        }

        // GET: Player/Edit/5
        public ActionResult Edit(int? id)
        {

            try
            {
                var PlayerDb = context.Players.Where(p => p.Id == id).FirstOrDefault();
                return View(PlayerDb);
            }
            catch (Exception)
            {
                return View();
            }
           
        }

        // POST: Player/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Player player)
        {
            try
            {
                var PlayerDb = context.Players.Where(p => p.Id == id).FirstOrDefault();
                PlayerDb.FirstName = player.FirstName;
                PlayerDb.LastName = player.LastName;
                PlayerDb.Age = player.Age;
                PlayerDb.City = player.City;
                PlayerDb.State = player.State;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Player/Delete/5
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
        //public ActionResult ChooseSport()
        //{
        //    var sport = 
        //}
    }
}
