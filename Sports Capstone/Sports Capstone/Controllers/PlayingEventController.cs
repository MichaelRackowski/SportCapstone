using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sports_Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static Sports_Capstone.Models.GoogleMapJson;

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

            return View(playingevent);
        }

        // GET: PlayingEvent/Details/5
        public ActionResult Details(int? id)
        {
            var playingEvent = context.PlayingEvents.FirstOrDefault((p => p.Id == id));

            ViewBag.thing = ApiKey.thing;
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
        public  ActionResult Create(PlayingEvent playingEvent)
        {
            try
            {
                // TODO: Add insert logic here

                Player currentPlayer = new Player();
                var ApplicationId = User.Identity.GetUserId();
                Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
                Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
                playingEvent.SkillLevel = sport.SkillLevel;
                playingEvent.SportName = sport.SportName;
                playingEvent.TypeOfPlay = sport.TypeOfPlay;
                playingEvent.CurrentPlayers++;


                //Player players = context.Events.Where(p => p.EventId == playingEvent.Id).FirstOrDefault();

                //Player Events = context.Events.Where(e => e.EventId);

                //foreach (var player. in playingEvent.Id)
                //{

                //}

                //Player currentnumPlayers = context.Players.Where(p => p.Id == playingEvent.Id).FirstOrDefault();
                /* get all players that have current playingeventId*/

                context.PlayingEvents.Add(playingEvent); 
                context.SaveChanges();

                GoogleApi(playingEvent.Id);
                context.SaveChanges();







                return RedirectToAction("Details", new { id = playingEvent.Id });
            }
            catch
            {
                return View(playingEvent);
            }
        }

        public ActionResult Find()
        {
            var ApplicationId = User.Identity.GetUserId();
            Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
            Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
            var playingevent = context.PlayingEvents.Where(p => p.SkillLevel == sport.SkillLevel);
            playingevent.Where(p => p.SportName == sport.SportName);
            playingevent.Where(p => p.TypeOfPlay == sport.TypeOfPlay).ToList();

            return RedirectToAction("Index");

        }

        public ActionResult Search(string SearchString)
        {
            var ApplicationId = User.Identity.GetUserId();
            Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
            Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
            List<PlayingEvent> playingEvents = context.PlayingEvents.Where(p => p.Location.Contains(SearchString)).ToList();
            playingEvents = playingEvents.Where(p => p.SportName == sport.SportName).ToList();
            playingEvents = playingEvents.Where(p => p.SkillLevel == sport.SkillLevel).ToList();
            playingEvents = playingEvents.Where(p => p.TypeOfPlay == sport.TypeOfPlay).ToList();

            return View("Index", playingEvents);                  
        }

        //public ActionResult PlayerSearch(string SearchString)
        //{
        //    var ApplicationId = User.Identity.GetUserId();
        //    Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
        //    Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
        //    List<Player> players = context.Players.Where(p => p. == SearchString).ToList();
        //    player.City = sport.City;
        //    players = players.Where(p => p.City == ).ToList();
        //    players = players.Where(p => p.)

        //    return View("Index")
        //}

        public ActionResult Join(int? id)
        {
            var ApplicationId = User.Identity.GetUserId();
            Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
            Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
            PlayingEvent playingEvent = context.PlayingEvents.Where(p => p.Id == id).FirstOrDefault();

            if (playingEvent.CurrentPlayers == playingEvent.PlayersAllowed)
            {
                return View("JoinFailed");
            }
            else
            {
                playingEvent.CurrentPlayers++;
                context.SaveChanges();
                return View("Join");
            }
        }

        public void GoogleApi(int? id)
        {
            var ApplicationId = User.Identity.GetUserId();
            Player player = context.Players.Where(p => p.ApplicationId == ApplicationId).FirstOrDefault();
            Sport sport = context.Sports.Where(s => s.PlayerId == player.Id).FirstOrDefault();
            PlayingEvent playingEvent = context.PlayingEvents.Where(p => p.Id == id).FirstOrDefault();
            var location = playingEvent.Location;
            var address = playingEvent.Address;
            var requestUrl = "https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "&key="+ ApiKey.Apikey;
            var newUrl = requestUrl.Replace(" ", "+");
            var result = new WebClient().DownloadString(newUrl);
            Rootobject root = JsonConvert.DeserializeObject<Rootobject>(result);
            var jsonObject = JObject.Parse(result);

            foreach (var item in root.results)
            {
                playingEvent.lat = item.geometry.location.lat;
                playingEvent.lng = item.geometry.location.lng;
            }

            //playingEvent.lat = lat.ToObject<double>();
            //playingEvent.lng = lng.ToObject<double>();

            //"https://maps.googleapis.com/maps/api/geocode/json?address=" + address + "CA&key=" + ApiKey.Apikey;

            //Console.WriteLine(lat);
            //Console.WriteLine(lng);
            context.SaveChanges();
            //Console.ReadLine();

            //return View("Details",playingEvent);
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
