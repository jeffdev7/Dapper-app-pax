using Dapper.menu.Domain.Persistence.Entities;
using Dapper.menu.Domain.Persistence.Model;

namespace Dapper.menu.Domain.Persistence.Interfaces
{
    public interface IPaxRepository : IBaseRepository<Pax>
    {
        Task<PaxGroup> GetPaxAndNumberOfThemAsync();
    }
}