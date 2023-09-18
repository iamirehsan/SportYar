using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class WalletsPaymentsTransactionsRepository : Repository<WalletsPaymentsTransaction>, IWalletsPaymentsTransactionsRepository
    {
        public WalletsPaymentsTransactionsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
