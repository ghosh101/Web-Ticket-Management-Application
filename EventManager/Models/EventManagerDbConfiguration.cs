using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;

namespace EventManager.Models
{
    public class EventManagerDbConfiguration : DropCreateDatabaseIfModelChanges<EventManagerDbContext>
    {
        protected override void Seed(EventManagerDbContext dbContext)
        {
            try
            {
                //var _event = new EventDbContext().Events.ToDictionary(e => e.eventId, e => e.eventId);
                //var _user = new UserDbContext().Users.ToDictionary(u => u.ticketId, u => u.ticketId);
                
                dbContext.EventAttributes.Add(new EventAttribute
                {                    
                    SectionNo = 1,
                    SeatNo = 22,                    
                    ticketStatus = "Active",
                    EventId = 1,
                    ticketId = 1

                });
                //dbContext.EventAttributes.Add(new EventAttribute
                //{
                //    EventId = 2,
                //    SectionNo = 4,
                //    SeatNo = 15,
                //    ticketId = 2,
                //    ticketStatus = "Disable"
                //});
                //dbContext.EventAttributes.Add(new EventAttribute
                //{
                //    EventId = 2,
                //    SectionNo = 4,
                //    SeatNo = 17,
                //    ticketId = 2,
                //    ticketStatus = "Active"
                //});

                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}