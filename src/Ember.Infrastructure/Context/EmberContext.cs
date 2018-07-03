using System.IO;
using Ember.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ember.Infrastructure.Context
{
  public class EmberContext : DbContext
  {
    public DbSet<Shirt> Shirts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // get the configuration from the app settings
      var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();
            
      // define the database to use
      optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
    }
  }
}