using SportYar.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Messages.Commands
{
    public class CreateOrUpdateAnnouncementsCommand
    {
        [Required]
        public SportsTypes SportType { get; set; }
        [Required]
        [GreaterOtEqualThanPresentDate]
        public DateTime Date { get; set; }
        public string StartingTimeInPersian { get; set; }
        [Required]
        public string EndingTimeInPersian { get; set; }
        [Required]
        public int Participant { get; set; }
        [Required]
        public int PricePerparticipant { get; set; }
        [Required]
        public int GeneralPrice { get; set; }
        [Required]
        public string Address { get; set; }
        public string? Description { get; set; }
        [Required]
        public string RegionId { get; set; }

    }
}
