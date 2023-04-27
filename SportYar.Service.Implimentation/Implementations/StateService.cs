using Microsoft.EntityFrameworkCore;
using SportYar.Messages.DTOs.State;
using SportYar.Repository;
using SportYar.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportYar.Service.Implimentation.Implementations
{
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CitiesDTO>> Cities(string name , string provinceId)
        {
            var cities = string.IsNullOrEmpty(name) ? await _unitOfWork.CitiesRepository.GetAllAsync() : (await _unitOfWork.CitiesRepository.Where(x => x.Name.Contains(name)).ToListAsync());
            return cities.Select(x => new CitiesDTO()
            {
                Name = x.Name,
            });
        }

        public async Task<IEnumerable<RegionsDTO>> Regions(string name , string cityId)
        {
            var regions = string.IsNullOrEmpty(name) ? await _unitOfWork.RegionsRepository.GetAllAsync() : (await _unitOfWork.RegionsRepository.Where(x => x.Name.Contains(name)).ToListAsync());
            return regions.Select(x => new RegionsDTO()
            {
                Name = x.Name,
            });
        }

        public Task<IEnumerable<ProvincesDTO>> Provinces(string name)
        {
            throw new NotImplementedException();
        }
    }
}
