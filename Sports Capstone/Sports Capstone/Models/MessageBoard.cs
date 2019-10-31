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

        [Display(Name ="Messages")]
        public string Messages { get; set; }

        //[Display(Name = "Location")]
        //public string Location { get; set; }

        //[Display(Name = "Sport")]
        //public string SportName { get; set; }

        //[Display(Name = "Type of Play")]
        //public string TypeOfPlay { get; set; }

        //[Display(Name = "Skil Level")]
        //public string SkillLevel { get; set; }

        //[Display(Name = "Address")]
        //public string Address { get; set; }

            [ForeignKey("PlayingEvent")]
            //[Display(Name ="PlayingEvent")]
            public int? PlayingEventId { get; set; }
        public PlayingEvent PlayingEvent { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }



    }
}