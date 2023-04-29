using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportYar.Base;
using SportYar.Infrastructure.Base;
using SportYar.Service.Interfaces;

namespace SportYar.Controllers
{
    [Route("api/SportYar/[controller]")]
    [ApiController]
    public class StateController : ApiControllerBase
    {
        private readonly IServiceHolder _serviceHolder;

        public StateController(IServiceHolder serviceHolder)
        {
            _serviceHolder = serviceHolder;
        }
        [AllowAnonymous]
        [HttpGet("Cities")]
        public async Task<IActionResult> Cities(string provinceId, int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending = false)
        {
            try
            {
                var result = await _serviceHolder.StateService.Cities(page, pageSize, orderByPropertyString, filterByPropertyString, filterByNameString, isDescending, provinceId);
                return OkResult("لیست شهر ها", result, result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet("Provinces")]
        public async Task<IActionResult> Provinces(int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending = false)
        {
            try
            {
                var result = await _serviceHolder.StateService.Provinces(page, pageSize, orderByPropertyString, filterByPropertyString, filterByNameString, isDescending);
                return OkResult("لیست استان ها", result, result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet("Regions")]
        public async Task<IActionResult> Regions(string cityId , int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDescending = false)
        {
            try
            {
                var result = await _serviceHolder.StateService.Regions(page, pageSize, orderByPropertyString, filterByPropertyString, filterByNameString, isDescending ,cityId);
                return OkResult("لیست محله ها", result, result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
