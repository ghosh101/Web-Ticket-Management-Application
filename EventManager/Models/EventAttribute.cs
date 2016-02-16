using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class EventAttribute
    {
        public EventAttribute()
        { }
                
        [Column(Order = 0), Key]
        public int? EventId { get; set; }

        [Column(Order = 1), Key]
        public int SectionNo { get; set; }

        [Column(Order = 2), Key]
        public int SeatNo { get; set; }
                
        public int? ticketId { get; set; }
                
        public string ticketStatus { get; set; }
        
        [ForeignKey("ticketId")]
        public virtual User _user { get; set; }

        //public virtual List<User> userList

        [ForeignKey("EventId")]
        public virtual Event _event { get; set; }
    }
}