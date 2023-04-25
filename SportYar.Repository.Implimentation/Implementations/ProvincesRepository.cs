using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class ProvincesRepository : Repository<Province>, IProvincesRepository
    {
        public ProvincesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
