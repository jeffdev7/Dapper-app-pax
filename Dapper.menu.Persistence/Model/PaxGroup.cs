using Dapper.menu.Domain.Persistence.Entities;

namespace Dapper.menu.Domain.Persistence.Model
{
    public class PaxGroup
    {
        public int Count { get; set; }
        public List<Pax> Paxs { get; set; }
    }
}
