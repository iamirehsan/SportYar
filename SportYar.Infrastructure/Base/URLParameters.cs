using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Infrastructure.Base
{
    public class URLParameters
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string? OrderByPropertyString { get; set; }
        public string? FilterByPropertyString { get; set; }
        public string? FilterByNameString { get; set; }
        public bool IsDescending { get; set; }



    }
}
