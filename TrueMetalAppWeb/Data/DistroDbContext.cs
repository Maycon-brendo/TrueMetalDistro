using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Data;

public class DistroDbContext : IdentityDbContext
{
    public DbSet<Patch> Patch { get; set; }
    public DbSet<Genero> Genero { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var stringConn = config.GetConnectionString("StringConn");

        optionsBuilder.UseSqlServer(stringConn);
    }
}
