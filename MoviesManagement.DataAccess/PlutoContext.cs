using System.Data.Entity;
using MoviesManagement.DataAccess.Core.Domain;

namespace MoviesManagement.DataAccess
{
    public class PlutoContext : DbContext
    {
        public PlutoContext() : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }


        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<MembershipType> MembershipTypes { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        
    }
}
