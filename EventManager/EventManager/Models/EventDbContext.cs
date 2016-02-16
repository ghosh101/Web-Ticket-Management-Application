using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}