using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Data.Entity.Infrastructure;
using System.Text;

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
                    TicketId = 1

                });
                dbContext.EventAttributes.Add(new EventAttribute
                {
                    EventId = 2,
                    SectionNo = 4,
                    SeatNo = 15,
                    TicketId = 2,
                    ticketStatus = "Disable"
                });
                dbContext.EventAttributes.Add(new EventAttribute
                {
                    EventId = 2,
                    SectionNo = 4,
                    SeatNo = 17,
                    TicketId = 2,
                    ticketStatus = "Active"
                });

                dbContext.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                //Debug.WriteLine(e.Message);
                var exception = HandleDbUpdateException(e);
                throw;
            }
        }

        private Exception HandleDbUpdateException(DbUpdateException e1)
        {
            var builder = new StringBuilder("A DbUpdateException was caught while saving changes. ");

            try
            {
                foreach (var result in e1.Entries)
                {
                    builder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
                }
            }
            catch (Exception e)
            {
                builder.Append("Error parsing DbUpdateException: " + e.ToString());
            }

            string message = builder.ToString();
            return new Exception(message, e1);
        }
    }
}