using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Splity.Domain.Entity
{
    public class User: IdentityUser
    {
        public string Name { get; set; } = string.Empty;  // Full name
        public string? ProfilePictureUrl { get; set; }    // Optional profile picture
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public ICollection<Group> GroupsOwned { get; set; } = new List<Group>();
        public ICollection<GroupMember> GroupMemberships { get; set; } = new List<GroupMember>();
        public ICollection<Expense> ExpensesPaid { get; set; } = new List<Expense>();
        public ICollection<ExpenseShare> ExpenseShares { get; set; } = new List<ExpenseShare>();
        public ICollection<Settlement> SettlementsPaid { get; set; } = new List<Settlement>();
        public ICollection<Settlement> SettlementsReceived { get; set; } = new List<Settlement>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();

        public User()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
