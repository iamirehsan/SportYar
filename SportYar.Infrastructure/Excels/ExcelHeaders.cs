using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Infrastructure.Excels
{
    public static class ExcelHeaders
    {
        public static Dictionary<string, int> CityHeaders()
        {
            return new Dictionary<string, int>
            {
                {"Id" , 1 } , {"Name",2} , {"ProvinceId" , 3}
            };
        }
        public static Dictionary<string, int> RegionHeaders()
        {
            return new Dictionary<string, int>
            {
                { "Id",1 } , {"Name",2} , {"Number",3} , {"CityId",4}
            };
        }
        public static Dictionary<string, int> ProvinceHeaders()
        {
            return new Dictionary<string, int>
            {
                { "Id",1 } , {"Name",2}
            };
        }



    }
}
