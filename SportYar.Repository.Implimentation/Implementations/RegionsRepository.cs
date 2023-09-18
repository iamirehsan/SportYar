using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class RegionsRepository : Repository<Region>, IRegionsRepository
    {
        public RegionsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
