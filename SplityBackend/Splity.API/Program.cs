using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Splity.Domain.Entities;
using Splity.Persistence.Database;
using Splity.Persistence.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddAuthorization();
        builder.Services.AddAuthentication()
            .AddCookie(IdentityConstants.ApplicationScheme)
            .AddBearerToken(IdentityConstants.BearerScheme);

        builder.Services.AddIdentityCore<User>()
            .AddEntityFrameworkStores<SplityDbContext>()
            .AddApiEndpoints();

        builder.Services.AddDbContext<SplityDbContext>(
            options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database")));


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.ApplyMigrations();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapIdentityApi<User>();
        app.MapControllers();

        app.Run();
    }
}