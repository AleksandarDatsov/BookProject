using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations.IdentityUserConfigurations
{
    public class ApplicationClaimMap : IEntityTypeConfiguration<IdentityUserClaim<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<long>> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
