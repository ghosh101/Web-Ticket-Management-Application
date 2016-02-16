using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class EventDbConfiguration : DropCreateDatabaseIfModelChanges<EventDbContext>
    {
        
        protected override void Seed(EventDbContext dbContext2)
        {
            
            dbContext2.Events.Add(new Event
            {
                eventName = "Sunday Soccer",
                eventDate = new DateTime(2015,12,15),
                isZone1 = "true",
                isZone2 = "true",
                isZone3 = "true",
                isZone4 = "false",
                isZone5 = "false",
                isZone6 = "false",
                isZone7 = "false",
                isZone8 = "true"
            });
            dbContext2.Events.Add(new Event
            {
                eventName = "Monday Football",
                eventDate = new DateTime(2016,01,14),
                isZone1 = "false",
                isZone2 = "false",
                isZone3 = "true",
                isZone4 = "false",
                isZone5 = "false",
                isZone6 = "true",
                isZone7 = "false",
                isZone8 = "true"
            });
            dbContext2.Events.Add(new Event
            {
                eventName = "Saturday Hockey",
                eventDate = new DateTime(2016,01,26),
                isZone1 = "false",
                isZone2 = "true",
                isZone3 = "true",
                isZone4 = "true",
                isZone5 = "false",
                isZone6 = "true",
                isZone7 = "false",
                isZone8 = "false"
            });
            
            dbContext2.SaveChanges();
        }
    }
}