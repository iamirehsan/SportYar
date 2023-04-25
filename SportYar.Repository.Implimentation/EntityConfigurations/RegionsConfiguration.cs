using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
