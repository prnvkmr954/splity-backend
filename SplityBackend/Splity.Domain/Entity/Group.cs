using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid OwnerId { get; set; }          // Who created the group
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public User? Owner { get; set; }             // Navigation to User
        public ICollection<GroupMember> Members { get; set; } = new List<GroupMember>();
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }

}
