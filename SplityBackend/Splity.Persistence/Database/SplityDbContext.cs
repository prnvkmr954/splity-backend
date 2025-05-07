using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Splity.Domain.Entities;

namespace Splity.Persistence.Database
{
    public class SplityDbContext(DbContextOptions<SplityDbContext> options) : IdentityDbContext<User>(options)
    {
        public DbSet<Expense> Expenses { get; set; }
        public required DbSet<User> Users { get; set; }
        public required DbSet<Group> GroupsOwned { get; set; }
        public required DbSet<GroupMember> GroupMembers { get; set; }
        public required DbSet<ExpenseShare> ExpenseShares { get; set; }
        public required DbSet<Settlement> Settlements { get; set; }
        public required DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(u => u.Initials).HasMaxLength(5);
            modelBuilder.HasDefaultSchema("identity");
        }
    }
    
}
