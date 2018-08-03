using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => new { b.Id, b.AuthorId, b.PublisherId, b.SubjectId });

            builder.Property(b => b.Title).IsRequired().HasMaxLength(50);
            builder.Property(b => b.DateOfPublishing).IsRequired();

            builder.HasOne(b => b.Subject)
                .WithMany(s => s.Books)
                .HasForeignKey(b => b.SubjectId);

            builder.HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            builder.HasOne(b => b.Publisher)
                .WithMany(s => s.Books)
                .HasForeignKey(b => b.PublisherId);
        }
    }
}
