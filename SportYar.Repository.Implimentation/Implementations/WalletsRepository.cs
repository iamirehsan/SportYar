using SportYar.Domain.Entites.Wallet;
using SportYar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class WalletsRepository : Repository<Wallet>, IWalletsRepository
    {
        public WalletsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
