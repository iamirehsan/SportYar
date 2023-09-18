using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites.Wallet;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class WalletsReceivesTransactionsConfiguration : BaseEntityConfiguration<WalletsReceivesTransaction>
    {
        public void Configure(EntityTypeBuilder<WalletsReceivesTransaction> builder)
        {
            
        }
    }
}
