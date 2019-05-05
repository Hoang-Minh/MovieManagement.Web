using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.DataAccess.Models;

namespace MoviesManagement.DataAccess.Infrastructure
{
    interface IEFDbContext : IDisposable
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<MembershipType> MembershipTypes { get; set; }
        DbSet<Movie> Movies { get; set; }

    }
}
