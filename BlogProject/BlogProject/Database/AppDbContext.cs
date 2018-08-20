using System.Data.Entity;
using BlogProject.Models;
using Bysunka.Database.Entites;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogProject.Database
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        public DbSet<BlogPost> Posts { get; set; }
    }
}