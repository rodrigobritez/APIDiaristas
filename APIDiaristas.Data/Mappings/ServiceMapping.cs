using APIDiaristas.Data.Helpers;
using APIDiaristas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telluria.Utils.Crud.Mapping;

namespace APIDiaristas.Data.Mappings;

public class ServiceMapping : BaseEntityMap<Service>
{
  public override void Configure(EntityTypeBuilder<Service> builder)
  {
    base.Configure(builder);

    builder.ToTable("services");

    // Base properties
    builder.MapBaseEntityDefaultProps("id_service");

    // Entity properties
    builder.Property(x => x.Avaliation).HasColumnType("varchar(255)").HasColumnName("avaliation").IsRequired();
    builder.Property(x => x.Stars).HasColumnType("smallint").HasColumnName("starts");
    
    // Relationships
    builder.HasOne(x => x.Client).WithMany().HasForeignKey(x => x.ClientId);
    builder.HasOne(x => x.DayWorker).WithMany().HasForeignKey(x => x.DayWorkerId);
  }
}