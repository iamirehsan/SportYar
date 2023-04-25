using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites
{
    public class City : BaseEntity
    {
        public virtual ICollection<Region> Regions { get; set; }
        public string? ProvinceId { get; set; }
        public virtual Province? Province { get; set; }
        public string Name { get; set; }
    }
}
