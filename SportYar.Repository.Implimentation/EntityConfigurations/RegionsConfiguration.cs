using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class RegionsConfiguration : BaseEntityConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasMany(o => o.Announcements).WithOne(o => o.Region).HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
