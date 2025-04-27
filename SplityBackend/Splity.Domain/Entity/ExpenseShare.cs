using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class ExpenseShare
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ExpenseId { get; set; }
        public Guid UserId { get; set; }
        public decimal AmountOwed { get; set; }

        // Relationships
        public Expense? Expense { get; set; }
        public User? User { get; set; }
    }

}
