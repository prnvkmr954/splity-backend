using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class Expense
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;       
        public string? Description { get; set; }
        public decimal TotalAmount { get; set; }
        public Guid PaidById { get; set; }                       
        public Guid GroupId { get; set; }
        public DateTime ExpenseDate { get; set; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public User? PaidBy { get; set; }
        public Group? Group { get; set; }
        public ICollection<ExpenseShare> Shares { get; set; } = new List<ExpenseShare>();
    }

}
