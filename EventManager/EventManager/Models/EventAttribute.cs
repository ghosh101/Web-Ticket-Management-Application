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

        [Key]
        public int Id { get; set; }
        
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        public int SectionNo { get; set; }

        public int SeatNo { get; set; }
                
        public int TicketId { get; set; }
        public virtual User User { get; set; }
                
        public string ticketStatus { get; set; }
        
        //[ForeignKey("ticketId")]
        //public virtual User _user { get; set; }

        ////public virtual List<User> userList

        //[ForeignKey("EventId")]
        //public virtual Event _event { get; set; }
    }
}