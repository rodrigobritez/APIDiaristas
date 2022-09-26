using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telluria.Utils.Crud.Entities;

namespace APIDiaristas.Data.Helpers;

public static class MappingHelper
{
  public static void MapBaseEntityDefaultProps<TEntity>(this EntityTypeBuilder<TEntity> builder, string idFieldName)
    where TEntity : BaseEntity
  {
    builder.Property(x => x.Id).HasColumnName(idFieldName).HasColumnType("uuid").IsRequired()
      .HasDefaultValueSql("(uuid_generate_v4())");
    builder.Property(x => x.CreatedAt).HasColumnName("created_at").HasColumnType("timestamp").IsRequired()
      .HasDefaultValueSql("(now() at time zone 'utc')");
    builder.Property(x => x.UpdatedAt).HasColumnName("updated_at").HasColumnType("timestamp");
    builder.Property(x => x.DeletedAt).HasColumnName("deleted_at").HasColumnType("timestamp");
    builder.Property(x => x.Deleted).HasColumnName("deleted").HasColumnType("boolean").IsRequired()
      .HasDefaultValue(false);
  }
}