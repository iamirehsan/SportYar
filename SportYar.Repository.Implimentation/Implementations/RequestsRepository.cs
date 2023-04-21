using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class RequestsRepository : Repository<Request>, IRequestsRepository
    {
        public RequestsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
