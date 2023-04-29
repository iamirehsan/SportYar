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
        public Task<IEnumerable<CitiesDTO>> Cities(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString , bool isDescending , string provinceId);
        public Task<IEnumerable<RegionsDTO>> Regions(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending , string cityId);
        public Task<IEnumerable<ProvincesDTO>> Provinces(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending);


    }
}
