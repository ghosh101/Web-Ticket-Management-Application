using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class UserDbContext : DbContext
    {        
        public DbSet<User> Users { get; set; }
                
    }
}