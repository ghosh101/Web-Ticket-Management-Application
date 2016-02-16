using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class Event
    {
        public Event()
        { }

        [Key]
        public int eventId { get; set; }
        public string eventName { get; set; }
        public DateTime eventDate { get; set; }
        public string isZone1 { get; set; }
        public string isZone2 { get; set; }
        public string isZone3 { get; set; }
        public string isZone4 { get; set; }
        public string isZone5 { get; set; }
        public string isZone6 { get; set; }
        public string isZone7 { get; set; }
        public string isZone8 { get; set; }
        
    }
}