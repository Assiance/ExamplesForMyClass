using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace MovieTracker.Data.Contexts;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(Core.Movie))!);
    }
}