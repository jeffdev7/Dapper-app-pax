using Dapper.menu.Domain.Persistence.Entities;
using Dapper.menu.Domain.Persistence.Interfaces;

namespace Dapper.menu.Domain.Persistence.Repositories
{
    public class PaxRepository : BaseRepository<Pax>, IPaxRepository
    {
        public PaxRepository(string connectionString) 
            : base(connectionString) { }
    }
}
