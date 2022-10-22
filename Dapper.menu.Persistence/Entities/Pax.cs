namespace Dapper.menu.Domain.Persistence.Entities
{
    [Table("Pax")]
    public class Pax : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
