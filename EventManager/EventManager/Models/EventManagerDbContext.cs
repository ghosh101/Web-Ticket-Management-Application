using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class EventManagerDbContext : DbContext
    {
        public DbSet<EventAttribute> EventAttributes { get; set; }
    }
}