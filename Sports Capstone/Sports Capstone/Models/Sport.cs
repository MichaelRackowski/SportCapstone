using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sports_Capstone.Models
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }

       [Display(Name ="Sport")]
       public string SportName { get; set; }

        [Display(Name = "Type of Play")]
        public string TypeOfPlay { get; set; }

        [Display(Name = "Skil Level")]
        public string SkillLevel { get; set; }

        //[ForeignKey("Player")]
        //[Display(Name ="Player")]
        //public int PlayerId { get; set; }
        // public Player Player { get; set; }


    }
}