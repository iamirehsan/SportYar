using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportYar.Domain.Entites.Wallet;

namespace SportYar.Repository.Implimentation.EntityConfigurations
{
    internal class WalletsConfiguration : BaseEntityConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasMany(x => x.WalletsReceivesTransactions).WithOne(x => x.Wallet).HasForeignKey(x => x.WalletId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.WalletsPaymentsTransactions).WithOne(x => x.Wallet).HasForeignKey(x => x.WalletId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
