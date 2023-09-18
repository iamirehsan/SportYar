using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class WalletsReceivesTransactionsRepository : Repository<WalletsReceivesTransaction>, IWalletsReceivesTransactionsRepository
    {
        public WalletsReceivesTransactionsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
