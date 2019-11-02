using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sports_Capstone.Models
{
    public class PlayingEvent
    {
        [Key]
        public int? Id { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = " Start Time of Event")]
        public int? StartTime { get; set; }

        [Display(Name = "End Time of Event")]
        public int? EndTime { get; set; }
        [Display(Name = "Number of players allowed")]
        public int PlayersAllowed { get; set; }

        [Display(Name = "Current Players")]
        public int CurrentPlayers { get; set; }

        //[ForeignKey("Players")]
        ////[Display(Name = "Players")]
        //public int PlayersId { get; set; }
        //public Player Player { get; set; }

        public ICollection<Player> Players { get; set; }

        [Display(Name = "Sport")]
        public string SportName { get; set; }

        [Display(Name = "Type of Play")]
        public string TypeOfPlay { get; set; }

        [Display(Name = "Skil Level")]
        public string SkillLevel { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        public double lat { get; set; }

        public double lng { get; set; }


   


       


    }
}