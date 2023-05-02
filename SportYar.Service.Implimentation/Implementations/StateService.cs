using Microsoft.EntityFrameworkCore;
using SportYar.Domain.Entites;
using SportYar.Infrastructure.Base;
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

        public async Task<IEnumerable<CitiesDTO>> Cities(URLParameters parameters, string provinceId)
        {
            var cities =  (await _unitOfWork.CitiesRepository.Where(x => x.ProvinceId == provinceId).ResponseActions(parameters).ToListAsync());
            return cities.Select(x => new CitiesDTO()
            {
                Name = x.Name,
                Id = x.Id,


            }); ;
 
        }

        public async Task<IEnumerable<RegionsDTO>> Regions(URLParameters parameters , string cityId)
        {
            var regions = await _unitOfWork.RegionsRepository.Where(x => x.CityId == cityId).ResponseActions(parameters).ToListAsync();
            return regions.Select(x => new RegionsDTO()
            {
                Name = x.Name,
                Id = x.Id,
            });
        }

        public async Task<IEnumerable<ProvincesDTO>> Provinces(URLParameters parameters)

        {
      
            var Provinces = await _unitOfWork.ProvincesRepository.AsQueryable().ResponseActions(parameters).ToListAsync();
            return Provinces.Select(x => new ProvincesDTO()
            {
                Name = x.Name,
                Id = x.Id,
            });
        }
    }
}
