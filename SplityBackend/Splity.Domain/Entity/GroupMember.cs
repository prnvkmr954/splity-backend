using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class GroupMember
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public Group Group { get; set; }
        public User User { get; set; }
    }

}
