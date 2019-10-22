using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sports_Capstone.Models
{
    public class Sports
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Type of Play")]
        public string TypeOfPlay { get; set; }

        [Display(Name = "Skil Level")]
        public string SkillLevel { get; set; }
    }
}