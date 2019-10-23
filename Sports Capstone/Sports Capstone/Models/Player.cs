using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sports_Capstone.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        public ICollection<Sport> SportOptions { get; set; }

        
        
        
        
        
        
        
        //[Display(Name = "Sport")]
        //public Sport SelctedSport { get; set; }

        //[ForeignKey("Sport")]
        //[Display(Name)]

    }
    //public enum Sport
    //{
    //    Basketball,
    //    Soccer,
    //    Golf
    //}
}