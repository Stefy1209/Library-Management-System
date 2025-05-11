using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Persistency.configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(book => book.Id);
        
        builder.Property(book => book.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(book => book.Quantity)
            .IsRequired();

        builder.Property(book => book.LoanedQuantity)
            .IsRequired();
        
        builder.Navigation(book => book.Authors)
            .UsePropertyAccessMode(PropertyAccessMode.Field);

        builder.HasMany(book => book.Authors)
            .WithMany(author => author.Books)
            .UsingEntity(j => j.ToTable("BookAuthor"));
        
        builder.Navigation(book => book.Statistics);

        builder.HasOne(book => book.Statistics)
            .WithOne(statistics => statistics.Book)
            .HasForeignKey<Statistics>(statistics => statistics.BookId)
            .IsRequired();
    }
}