using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class ProvincesRepository : Repository<Province>, IProvincesRepository
    {
        public ProvincesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
