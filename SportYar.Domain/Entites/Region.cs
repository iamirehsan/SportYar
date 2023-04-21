using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites
{
    public class Region : BaseEntity
    {
        public int Number { get; set; }
        public string Area { get; set; }

        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
