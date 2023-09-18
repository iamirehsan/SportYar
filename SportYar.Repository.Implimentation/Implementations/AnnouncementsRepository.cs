using SportYar.Domain.Entites;
using SportYar.Repository.Interfaces;

namespace SportYar.Repository.Implimentation.Implementations
{
    public class AnnouncementsRepository : Repository<Announcement>, IAnnouncementsRepository
    {
        public AnnouncementsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
