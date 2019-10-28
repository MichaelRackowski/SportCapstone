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

        [ForeignKey("Messages")]
        [Display(Name = "Messages")]
        public int MessageId { get; set; }
        public Message Message { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}