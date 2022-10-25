namespace Dapper.menu.Domain.Persistence.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int EntityId { get; set; }
        public DateTime CreatedAt { get;  set; }
        public DateTime? UpdatedAt { get;  set; }

    }
}
