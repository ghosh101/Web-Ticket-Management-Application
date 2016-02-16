using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventManager.Models
{
    public class UserDbConfiguration : DropCreateDatabaseIfModelChanges<UserDbContext>
    {
        protected override void Seed(UserDbContext userDbContext)
        {
            userDbContext.Users.Add(new User
            {
                fName = "Suman",
                lName = "Ghosh",
                userType = "Customer",
                ticketId = 4123578
            });
            userDbContext.Users.Add(new User
            {
                fName = "Arun",
                lName = "Kandari",
                userType = "Customer",
                ticketId = 4453578
            });

            userDbContext.SaveChanges();
        }
    }
}