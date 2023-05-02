using SportYar.Infrastructure.Base;
using SportYar.Messages.DTOs.State;

namespace SportYar.Service.Interfaces
{
    public interface IStateService
    {
        public Task<IEnumerable<CitiesDTO>> Cities(URLParameters parameters, string provinceId);
        public Task<IEnumerable<RegionsDTO>> Regions(URLParameters parameters, string cityId);
        public Task<IEnumerable<ProvincesDTO>> Provinces(URLParameters parameters);


    }
}
