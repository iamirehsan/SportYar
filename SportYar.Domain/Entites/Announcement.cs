using SportYar.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites
{
    public class Announcement : BaseEntity
    {
        public string UserId{ get; set; }
        public string? RegionId { get; set; }
        public virtual Region? Region { get; set; }
        public virtual ICollection<Request> Requests{ get; set; }

        public SportsTypes SportType { get; set; }
        public DateTime Date{ get; set; }
        public string StartingTimeInPersian { get; set; }
        public string EndingTimeInPersian { get; set; }
        public int Participant { get; set; }
        public int PricePerparticipant { get; set; }
  
        public string Address{ get; set; }
        public string Description { get; set; }
        public bool IsExpired { get; set; }
        public bool IsDeleted { get; set; }

        public Announcement(string userId , SportsTypes sportType, DateTime date, string startingTimeInPersian, string endingTimeInPersian, 
            int participant, int pricePerparticipant,string address, string description)
        {
            UserId = userId;
            SportType = sportType;
            Date = date;
            StartingTimeInPersian = startingTimeInPersian;
            EndingTimeInPersian = endingTimeInPersian;
            Participant = participant;
            PricePerparticipant = pricePerparticipant;
            Address = address;
            Description = description;
 
        }
    }
}
