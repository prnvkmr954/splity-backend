using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class Settlement
    {
        [Key]
        public int Id { get; set; }

        public string FromUserId { get; set; } = string.Empty;
        public User? FromUser { get; set; }

        public string ToUserId { get; set; } = string.Empty;
        public User? ToUser { get; set; }

        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }


}
