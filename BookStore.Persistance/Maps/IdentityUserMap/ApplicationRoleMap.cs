using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations.IdentityUserConfigurations
{
    public class ApplicationRoleMap : IEntityTypeConfiguration<IdentityRole<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<long>> builder)
        {
            builder.HasKey(u => u.Id);
            builder.ToTable("IdentityRole");
        }
    }
}
