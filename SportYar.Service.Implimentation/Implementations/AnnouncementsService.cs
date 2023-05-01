using SportYar.Messages;
using SportYar.Repository;
using SportYar.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Service.Implimentation.Implementations
{
    public class AnnouncementsService : IAnnouncementsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnnouncementsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public Task<IEnumerable<AnnouncementsDTO>> Announcements(URLParameters parameters)
        //{

        //}
    }
}
