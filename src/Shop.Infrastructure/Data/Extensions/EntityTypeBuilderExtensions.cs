using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Core.Common;

namespace Shop.Infrastructure.Data.Extensions;

public static class EntityTypeBuilderExtensions
{
    /// <summary>
    /// Configuração da entidade base.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="builder"></param>
    public static void ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : BaseEntity
    {
        builder
            .HasKey(entity => entity.Id); // Primary Key

        builder
            .Property(entity => entity.Id)
            .IsRequired() // NOT NULL
            .ValueGeneratedNever(); // O Id será gerado ao instanciar a classe

        // Ignorando a propriedade "DomainEvents" para não ser criada a coluna na tabela.
        builder
            .Ignore(entity => entity.DomainEvents);
    }
}