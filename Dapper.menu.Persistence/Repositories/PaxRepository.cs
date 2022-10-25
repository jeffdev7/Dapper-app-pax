using Dapper.menu.Domain.Persistence.Entities;
using Dapper.menu.Domain.Persistence.Interfaces;
using Dapper.menu.Domain.Persistence.Model;
using System.Data.SqlClient;

namespace Dapper.menu.Domain.Persistence.Repositories
{
    public class PaxRepository : BaseRepository<Pax>, IPaxRepository
    {
        public PaxRepository(string connectionString) 
            : base(connectionString) { }

        public async Task<PaxGroup> GetPaxAndNumberOfThemAsync()
        {
            await using var connection = new SqlConnection(ConnectionString);
            string query = @"SELECT COUNT(*) FROM Pax
                            SELECT * FROM Pax";
            var reader = await connection.QueryMultipleAsync(sql: query);

            return new PaxGroup
            {
                Count = (await reader.ReadAsync<int>()).FirstOrDefault(),
                Paxs = (await reader.ReadAsync<Pax>()).ToList()
            };
        }
    }
}
