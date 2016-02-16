using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class User
    {
        public User()
        { }

        public string fName { get; set; }
        public string lName { get; set; }
        public string userType { get; set; }
        
        [Key]
        public int ticketId { get; set; }

        public virtual ICollection<EventAttribute> eventAttribute1 { get; set; }
    }
}