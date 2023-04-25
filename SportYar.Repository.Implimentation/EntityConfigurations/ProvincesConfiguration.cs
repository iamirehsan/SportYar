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
    public class ProvincesConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasMany(o => o.Cities).WithOne(o => o.Province).HasForeignKey(x => x.ProvinceId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
