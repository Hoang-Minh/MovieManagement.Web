using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.DataAccess.Infrastructure;

namespace MoviesManagement.DataAccess.Repositories
{
    public class BaseRepository
    {
        public MyDbContext DbContext = new MyDbContext();
    }
}
