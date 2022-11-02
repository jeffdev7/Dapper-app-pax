namespace Dapper.menu.Domain.Persistence.Entities
{
    [Table("Pax")]
    public class Pax : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Email { get; private set; }
        public string? PhoneNumber { get; private set; }

        public Pax(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        private Pax() { }

        //void UpdateEmail(string email) =>  Email = email;
        
    }
}
