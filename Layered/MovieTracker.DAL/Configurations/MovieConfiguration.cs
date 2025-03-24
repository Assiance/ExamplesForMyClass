using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieTracker.Core;

namespace MovieTracker.Data.Configurations;

public class MovieConfiguration
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Title).IsRequired().HasMaxLength(200);
        builder.Property(m => m.ReleaseDate).IsRequired();
    }
}