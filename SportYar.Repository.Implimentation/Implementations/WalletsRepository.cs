using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class WalletsRepository : Repository<Wallet>, IWalletsRepository
    {
        public WalletsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
