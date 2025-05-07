using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Splity.Domain.Entities;

namespace Splity.Persistence.Database
{
    public class SplityDbContext: IdentityDbContext<User>
    {
        public SplityDbContext(DbContextOptions<SplityDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(u => u.Initials).HasMaxLength(5);
            modelBuilder.HasDefaultSchema("identity");
        }
    }
    
}
