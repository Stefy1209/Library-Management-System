using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Persistency.configuration;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(author => author.Id);
        
        builder.Property(author => author.Name)
            .IsRequired()
            .HasMaxLength(100);

        var navigation = builder.Metadata.FindNavigation(nameof(Author.Books));
        navigation?.SetPropertyAccessMode(PropertyAccessMode.Field);
    }
}