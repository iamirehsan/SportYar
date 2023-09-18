using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites.Wallet;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class WalletsPaymentsTransactionsConfiguration : BaseEntityConfiguration<WalletsPaymentsTransaction>
    {
        public void Configure(EntityTypeBuilder<WalletsPaymentsTransaction> builder)
        {
         
        }
    }
}
