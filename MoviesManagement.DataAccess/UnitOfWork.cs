using MoviesManagement.DataAccess.Core;
using MoviesManagement.DataAccess.Core.Repositories;
using MoviesManagement.DataAccess.Persistence.Repositories;

namespace MoviesManagement.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            MembershipTypes = new MembershipTypeRepository(_context);
        }

        public IMembershipTypeRepository MembershipTypes { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
