using SportYar.Messages.DTOs.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Service.Interfaces
{
    public interface IStateService
    {
        public Task<IEnumerable<CitiesDTO>> Cities(string name , string provinceId);
        public Task<IEnumerable<RegionsDTO>> Regions(string name, string cityId);
        public Task<IEnumerable<ProvincesDTO>> Provinces(string name);


    }
}
