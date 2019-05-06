using System.Data.Entity;
using MoviesManagement.DataAccess.Models;

namespace MoviesManagement.DataAccess.Infrastructure
{
    public class MyDbContext : DbContext, IEFDbContext
    {
        public MyDbContext() : base("name=DefaultConnection")
        {
            
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
