using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MC3_Music.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MC3_Music.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }
        public DbSet<Customer> Customers { get; set; }
        //public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}