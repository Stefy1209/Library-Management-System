using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Persistency.configuration;

public class StatisticsConfiguration : IEntityTypeConfiguration<Statistics>
{
    public void Configure(EntityTypeBuilder<Statistics> builder)
    {
        builder.HasKey(statistics => statistics.Id);
        
        builder.Property(statistics => statistics.NrTimesLoaned)
            .IsRequired();
    }
}