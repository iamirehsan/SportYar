using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class RequestsRepository : Repository<Request>, IRequestsRepository
    {
        public RequestsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
