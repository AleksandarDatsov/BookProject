using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations
{
    public class UserSubjectMap : IEntityTypeConfiguration<UserSubject>
    {
        public void Configure(EntityTypeBuilder<UserSubject> builder)
        {
            builder.HasKey(s => new { s.Id, s.SubjectId });

            builder.HasOne(o => o.User).WithMany(c => c.UserSubject);
            builder.HasOne(o => o.Subject).WithMany(s => s.UserSubject);
        }
    }
}
