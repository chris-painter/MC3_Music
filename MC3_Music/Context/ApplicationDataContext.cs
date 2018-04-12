using MC3_Music.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MC3_Music.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        //public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}