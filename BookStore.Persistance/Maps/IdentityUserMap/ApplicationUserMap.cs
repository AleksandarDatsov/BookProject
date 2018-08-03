using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations.IdentityUserConfigurations
{
    public class ApplicationUserMap : IEntityTypeConfiguration<IdentityUser<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUser<long>> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email).HasMaxLength(50).IsRequired();
            builder.Property(u => u.UserName).HasMaxLength(50).IsRequired();
            builder.ToTable("IdentityUser");
        }
    }
}
