using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportYar.Domain.Entites;
using SportYar.Infrastructure.Base;
using SportYar.Messages.Commands;
using SportYar.Messages.DTOs;
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
        private readonly IMapper _mapper;

        public AnnouncementsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AnnouncementsDTO>> Announcements(URLParameters parameters, bool isExpiredAllowed)
        {
            var announcements = _unitOfWork.AnnouncementsRepository.Where(x => x.UserId == TokenClaims.GetTokenUserId() && x.IsDeleted == false && x.IsExpired == isExpiredAllowed);
            var result = (await announcements.Select(x => _mapper.Map<AnnouncementsDTO>(x)).ResponseActions(parameters).ToListAsync());
            return result;

        }
        public async Task<string> CreateAnnouncements(CreateOrUpdateAnnouncementsCommand cmd)
        {
            var announcements = new Announcement(TokenClaims.GetTokenUserId(), cmd.SportType, cmd.Date, cmd.StartingTimeInPersian, cmd.EndingTimeInPersian, cmd.Participant,
            cmd.GeneralPrice, cmd.Address, cmd.Description);
            announcements.Region = await _unitOfWork.RegionsRepository.FirstOrDefaultAsync(x => x.Id == cmd.RegionId);
            await _unitOfWork.SaveAsync();
            return announcements.Id;

        }
        public async Task UpdateAnnouncements(CreateOrUpdateAnnouncementsCommand cmd, string announcementsId)
        {
            var announcement = await _unitOfWork.AnnouncementsRepository.FirstOrDefaultAsync(x => x.Id == announcementsId);
            if (announcement == null)
                throw new ManagedException("آگهی وجود خارجی ندارد.");
            announcement.UpdateAt = DateTime.Now;
            announcement.Region = await _unitOfWork.RegionsRepository.FirstOrDefaultAsync(x => x.Id == cmd.RegionId);
            announcement.Description = cmd.Description;
            announcement.PricePerparticipant = cmd.PricePerparticipant;
            announcement.Address = cmd.Address;
            announcement.Participant = cmd.Participant;
            announcement.SportType = cmd.SportType;
            announcement.StartingTimeInPersian = cmd.StartingTimeInPersian;
            announcement.EndingTimeInPersian = cmd.EndingTimeInPersian;
            await _unitOfWork.SaveAsync();

        }
        public async Task DeleteAnnouncements(string announcementsId)
        {
            var announcement = await _unitOfWork.AnnouncementsRepository.FirstOrDefaultAsync(x => x.Id == announcementsId);
            if (announcement == null)
                throw new ManagedException("آگهی وجود خارجی ندارد.");
            _unitOfWork.AnnouncementsRepository.Remove(announcement);
            await _unitOfWork.SaveAsync();

        }
    }
}
