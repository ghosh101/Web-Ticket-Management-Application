namespace EventManager.Migrations
{
    using EventManager.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EventManager.Models.EventDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EventManager.Models.EventDbContext";
        }

        protected override void Seed(EventManager.Models.EventDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var events = new List<Event>
            {
                new Event { eventName="Sunday Soccer", eventDate = new DateTime(2015,12,15), isZone1 = "true",
                isZone2 = "true", isZone3 = "true", isZone4 = "false", isZone5 = "false", isZone6 = "false", isZone7 = "false",
                isZone8="true"}
            };

            events.ForEach(e => context.Events.AddOrUpdate(p => p.eventName, e));
            context.SaveChanges();
        }
    }
}
