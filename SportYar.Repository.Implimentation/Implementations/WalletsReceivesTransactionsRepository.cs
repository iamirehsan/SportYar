using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class WalletsReceivesTransactionsRepository : Repository<WalletsReceivesTransaction>, IWalletsReceivesTransactionsRepository
    {
        public WalletsReceivesTransactionsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
