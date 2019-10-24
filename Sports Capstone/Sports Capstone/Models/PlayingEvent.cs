﻿using System;
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
        public int Id { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = " Start Time of Event")]
        public DateTime? StartTime { get; set; }

        [Display(Name = "End Time of Event")]
        public DateTime? EndTime { get; set; }

        [ForeignKey("Players")]
        [Display(Name = "Players")]
        public int PlayersId { get; set; }
        public Player Players { get; set; }

        public ICollection<Player> Player { get; set; }

        [Display(Name = "Sport")]
        public string SportName { get; set; }

        [Display(Name = "Type of Play")]
        public string TypeOfPlay { get; set; }

        [Display(Name = "Skil Level")]
        public string SkillLevel { get; set; }



        //this is for the count of current players out of total number of players


    }
}