using Microsoft.EntityFrameworkCore;
using SportYar.Domain.Entites;
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
            var cities = string.IsNullOrEmpty(name) ? await  _unitOfWork.CitiesRepository.Where(x=>x.ProvinceId==provinceId).ToListAsync() : (await _unitOfWork.CitiesRepository.Where(x => x.Name.Contains(name) && x.ProvinceId==provinceId).ToListAsync());
            return cities.Select(x => new CitiesDTO()
            {
                Name = x.Name,
                Id = x.Id,
                
                
            });;
        }

        public async Task<IEnumerable<RegionsDTO>> Regions(string name , string cityId)
        {
            var regions = string.IsNullOrEmpty(name) ? await _unitOfWork.RegionsRepository.Where(x=>x.CityId==cityId).ToListAsync() : (await _unitOfWork.RegionsRepository.Where(x => x.Name.Contains(name) && x.CityId==cityId).ToListAsync());
            return regions.Select(x => new RegionsDTO()
            {
                Name = x.Name,
                Id=x.Id,
            });
        }

        public async Task<IEnumerable<ProvincesDTO>> Provinces(string name)
        {
            var regions = string.IsNullOrEmpty(name) ? await _unitOfWork.ProvincesRepository.GetAllAsync(): (await _unitOfWork.ProvincesRepository.Where(x => x.Name.Contains(name)).ToListAsync());
            return regions.Select(x => new ProvincesDTO()
            {
                Name = x.Name,
                Id = x.Id,
            });
        }
    }
}
