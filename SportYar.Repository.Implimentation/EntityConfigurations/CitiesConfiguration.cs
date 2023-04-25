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
    public class CitiesConfiguration : BaseEntityConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            //builder.HasMany(o => o.Regions).WithOne(o => o.City).HasForeignKey(x => x.CityId).IsRequired(false);
        }
    }
}
