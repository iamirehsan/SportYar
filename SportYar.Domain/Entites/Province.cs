using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Domain.Entites
{
    public class Province:BaseEntity
    {
        public virtual ICollection<City> Cities { get; set; }
        public string Name { get; set; }
    }
}
