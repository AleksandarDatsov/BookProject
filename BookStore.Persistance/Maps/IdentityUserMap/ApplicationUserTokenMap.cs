using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Persistance.EntitiesConfigurations.IdentityUserConfigurations
{
    public class ApplicationUserTokenMap : IEntityTypeConfiguration<IdentityUserToken<long>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<long>> builder)
        {
            builder.HasKey(u => u.UserId);
        }
    }
}
