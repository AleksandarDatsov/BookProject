using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations
{
    public class PublisherMap : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.HasMany(p => p.Books).WithOne(b => b.Publisher);
        }
    }
}
