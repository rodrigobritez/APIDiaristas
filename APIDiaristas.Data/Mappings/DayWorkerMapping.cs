using APIDiaristas.Data.Helpers;
using APIDiaristas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telluria.Utils.Crud.Mapping;

namespace APIDiaristas.Data.Mappings;

public class DayWorkerMapping : BaseEntityMap<DayWorker>
{
  public override void Configure(EntityTypeBuilder<DayWorker> builder)
  {
    base.Configure(builder);

    builder.ToTable("day_workers");

    // Base properties
    builder.MapBaseEntityDefaultProps("id_day_worker");

    // Entity properties
    builder.Property(x => x.Name).HasColumnType("varchar(60)").HasColumnName("name").IsRequired();
    builder.Property(x => x.Email).HasColumnType("varchar(100)").HasColumnName("email").IsRequired();
    builder.Property(x => x.CPF).HasColumnType("varchar(14)").HasColumnName("cpf").IsRequired();
    builder.Property(x => x.RG).HasColumnType("varchar(15)").HasColumnName("rg").IsRequired();
    builder.Property(x => x.TotalStars).HasColumnType("smallint").HasColumnName("total_stars");
    builder.Property(x => x.Active).HasColumnType("boolean").HasColumnName("active").IsRequired();

    // indexes
    builder.HasIndex(x => new { x.CPF }).IsUnique();
    builder.HasIndex(x => new { x.Email }).IsUnique();
  }
}