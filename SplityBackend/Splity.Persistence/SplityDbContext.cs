using Microsoft.EntityFrameworkCore;
using Splity.Domain.Entity;

namespace Splity.Persistence
{
    public class SplityDbContext(DbContextOptions options): DbContext(options)
    {
        public required DbSet<User> Users { get; set; }
    }
}
