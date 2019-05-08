using System;
using MoviesManagement.DataAccess.Core.Repositories;

namespace MoviesManagement.DataAccess.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IMembershipTypeRepository MembershipTypes { get; }
        int Complete();
    }
}
