using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Splity.Persistence.Database;

namespace Splity.Persistence.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using SplityDbContext context = scope.ServiceProvider.GetRequiredService<SplityDbContext>();
            context.Database.Migrate();
        }
    }
}
