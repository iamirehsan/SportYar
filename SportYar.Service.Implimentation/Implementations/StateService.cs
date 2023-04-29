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

        public async Task<IEnumerable<CitiesDTO>> Cities(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending , string provinceId)
        {
            var cities =  (await _unitOfWork.CitiesRepository.Where(x => x.ProvinceId == provinceId).ResponseActions(page, pageSize, orderByPropertyString, filterByPropertyString, filterByNameString, isDescending).ToListAsync());
            return cities.Select(x => new CitiesDTO()
            {
                Name = x.Name,
                Id = x.Id,


            }); ;
 
        }

        public async Task<IEnumerable<RegionsDTO>> Regions(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending, string cityId)
        {
            var regions = await _unitOfWork.RegionsRepository.Where(x => x.CityId == cityId).ResponseActions(page, pageSize, orderByPropertyString, filterByPropertyString, filterByNameString, isDescending).ToListAsync();
            return regions.Select(x => new RegionsDTO()
            {
                Name = x.Name,
                Id = x.Id,
            });
        }

        public async Task<IEnumerable<ProvincesDTO>> Provinces(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending)

        {
            var a = _unitOfWork.ProvincesRepository.Where(x => x.Name.Contains("الب"));
            var Provinces = await _unitOfWork.ProvincesRepository.AsQueryable().ResponseActions(page, pageSize, orderByPropertyString, filterByPropertyString, filterByNameString, isDescending).ToListAsync();
            return Provinces.Select(x => new ProvincesDTO()
            {
                Name = x.Name,
                Id = x.Id,
            });
        }
    }
}
