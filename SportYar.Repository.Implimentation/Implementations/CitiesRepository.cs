using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class CitiesRepository : Repository<City>, ICitiesRepository
    {
        public CitiesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
