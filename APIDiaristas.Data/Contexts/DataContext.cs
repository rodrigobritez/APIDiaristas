using APIDiaristas.Data.Helpers;
using APIDiaristas.Data.Mappings;
using Microsoft.EntityFrameworkCore;
namespace APIDiaristas.Data.Contexts;

public class DataContext : DbContext
{

  public DataContext(DbContextOptions<DataContext> options) : base(options)
  {
    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.HasDefaultSchema("api_ediaristas");

    // Application mappings
    modelBuilder.ApplyConfiguration(new ClientMapping());
    modelBuilder.ApplyConfiguration(new DayWorkerMapping());
    modelBuilder.ApplyConfiguration(new ServiceMapping());
    
  }

  protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
  {
    configurationBuilder
      .Properties<DateTime>()
      .HaveConversion<TypeConverterHelper.DateTimeConverter>();
  }
}