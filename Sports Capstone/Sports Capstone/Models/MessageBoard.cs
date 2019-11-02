using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Sports_Capstone.Models
{
    public class MessageBoard
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Messages")]
        public string Messages { get; set; }

        [Display(Name = "Review")]
        public string Review { get; set; }

        [Display(Name = "Rating")]
        public int? Rating { get; set; }

       [ForeignKey("PlayingEvent")]
        public int? PlayingEventId { get; set; }
        public PlayingEvent PlayingEvent { get; set; }

        [ForeignKey("Player")]
        public int? PlayersId { get; set; }
        public Player Player { get; set; }
        
    }
}