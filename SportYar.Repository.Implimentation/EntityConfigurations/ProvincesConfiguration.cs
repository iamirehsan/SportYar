using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    public class ProvincesConfiguration :   BaseEntityConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            //builder.HasMany(o => o.Cities).WithOne(o => o.Province).HasForeignKey(x => x.ProvinceId).IsRequired(false);
        }
    }
}
