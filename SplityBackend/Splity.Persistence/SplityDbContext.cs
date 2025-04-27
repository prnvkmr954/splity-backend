using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Splity.Domain.Entity;

namespace Splity.Persistence
{
    public class SplityDbContext(DbContextOptions options): IdentityDbContext<User>(options)
    {
        public required DbSet<User> Users { get; set; }
        public required DbSet<Group> GroupsOwned { get; set; } 
        public required DbSet<GroupMember> GroupMembers { get; set; } 
        public required DbSet<Expense> Expenses{ get; set; } 
        public required DbSet<ExpenseShare> ExpenseShares { get; set; } 
        public required DbSet<Settlement> Settlements{ get; set; } 
        public required DbSet<Notification> Notifications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Settlement>()
                .HasOne(s => s.FromUser)
                .WithMany(u => u.SettlementsPaid)
                .HasForeignKey(s => s.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Settlement>()
                .HasOne(s => s.ToUser)
                .WithMany(u => u.SettlementsReceived)
                .HasForeignKey(s => s.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
