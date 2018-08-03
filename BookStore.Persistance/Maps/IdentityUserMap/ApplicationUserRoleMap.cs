using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations.IdentityUserConfigurations
{
    public class ApplicationUserRoleMap : IEntityTypeConfiguration<IdentityUserRole<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<long>> builder)
        {
            builder.HasKey(u => u.UserId);
        }
    }
}
