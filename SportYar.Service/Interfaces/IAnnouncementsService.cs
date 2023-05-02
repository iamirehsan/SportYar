using SportYar.Infrastructure.Base;
using SportYar.Messages.Commands;
using SportYar.Messages.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Service.Interfaces
{
    public interface IAnnouncementsService
    {
        public Task DeleteAnnouncements(string announcementsId);
        public Task UpdateAnnouncements(CreateOrUpdateAnnouncementsCommand cmd, string announcementsId);
        public Task<string> CreateAnnouncements(CreateOrUpdateAnnouncementsCommand cmd);
        public Task<IEnumerable<AnnouncementsDTO>> Announcements(URLParameters parameters, bool isExpiredAllowed);
    }
}
