using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportYar.Base;
using SportYar.Infrastructure.Base;
using SportYar.Messages.Commands;
using SportYar.Service.Interfaces;

namespace SportYar.Controllers
{
    [Route("api/sportyar/[controller]")]
    [ApiController]
    public class AnnouncementController : ApiControllerBase
    {
        private readonly IServiceHolder _serviceHolder;

        public AnnouncementController(IServiceHolder serviceHolder)
        {
            _serviceHolder = serviceHolder;
        }
        [HttpGet]
        public async Task<IActionResult> Announcements(bool isExpiredValid = false)
        {
            var result = await _serviceHolder.AnnouncementsService.Announcements(Parameters, isExpiredValid);
            return OkResult("لیست آگهی ها", result, result.Count());
        }
        [HttpPost]
        public async Task<IActionResult> CreatesAnnouncement(CreateOrUpdateAnnouncementsCommand cmd)
        {
            var result = await _serviceHolder.AnnouncementsService.CreateAnnouncements(cmd);
            return OkResult("آگهی با موفقیت ساخته شد." , new { Id = result } , 1);
        }
        [HttpDelete("{announcementsId}")]
        public async Task<IActionResult> DeletesAnnouncement(string announcementsId)
        {

            await _serviceHolder.AnnouncementsService.DeleteAnnouncements(announcementsId);
            return OkResult("آگهی با موفقیت حدف شد.");
        }
        [HttpPut("{announcementsId}")]
        public async Task<IActionResult> DeletesAnnouncement(CreateOrUpdateAnnouncementsCommand cmd ,  string announcementsId)
        {

            await _serviceHolder.AnnouncementsService.UpdateAnnouncements(cmd , announcementsId);
            return OkResult("آگهی با موفقیت ویرایش شد.");
        }
    }
}
