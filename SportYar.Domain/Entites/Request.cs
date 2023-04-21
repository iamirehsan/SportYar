using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites
{
    public class Request : BaseEntity
    {
        public string UserId{ get; set; }
        public virtual Announcement Announcement { get; set; }
        public string AnnouncementId{ get; set; }
        public bool IsDeleted { get; set; }
        public bool IsExpired{ get; set; }
        public string PaymentId { get; set; }
        public string IsPayedByWallet { get; set; }


    }
}
