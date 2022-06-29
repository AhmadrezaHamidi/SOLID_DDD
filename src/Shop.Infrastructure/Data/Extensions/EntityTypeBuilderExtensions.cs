using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core;

namespace Shop.Infrastructure.Data.Extensions;

public static class EntityTypeBuilderExtensions
{
    /// <summary>
    /// Configuração da entidade base <see cref="BaseEntity" />.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="builder"></param>
    public static void ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder) where TEntity : BaseEntity
    {
        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id)
            .IsRequired()           // NOT NULL
            .ValueGeneratedNever(); // VALUE GENERATED BY THE APPLICATION
    }
}