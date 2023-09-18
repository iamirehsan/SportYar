using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites;

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
