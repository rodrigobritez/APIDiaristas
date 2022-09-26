using APIDiaristas.Data.Helpers;
using APIDiaristas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telluria.Utils.Crud.Mapping;

namespace APIDiaristas.Data.Mappings;

public class ClientMapping : BaseEntityMap<Client>
{
  public override void Configure(EntityTypeBuilder<Client> builder)
  {
    base.Configure(builder);

    builder.ToTable("clients");

    // Base properties
    builder.MapBaseEntityDefaultProps("id_client");

    // Entity properties
    builder.Property(x => x.Name).HasColumnType("varchar(60)").HasColumnName("name").IsRequired();
    builder.Property(x => x.Email).HasColumnType("varchar(100)").HasColumnName("email").IsRequired();
    
    // indexes
    builder.HasIndex(x => new { x.Email }).IsUnique();
  }
}