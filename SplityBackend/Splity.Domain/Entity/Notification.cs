using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class Notification
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string Message { get; set; } = string.Empty;  // Content like "You owe ₹500 to Rahul"
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public User? User { get; set; }
    }

}
