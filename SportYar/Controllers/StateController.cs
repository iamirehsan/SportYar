using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportYar.Base;
using SportYar.Infrastructure.Base;
using SportYar.Messages;
using SportYar.Service.Interfaces;

namespace SportYar.Controllers
{
    [Route("api/sportyar/[controller]")]
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
        public async Task<IActionResult> Cities(string provinceId)
        {
            try
            {
                
                var result = await _serviceHolder.StateService.Cities(Parameters, provinceId);
                return OkResult("لیست شهر ها", result, result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet("Provinces")]
        public async Task<IActionResult> Provinces()
        {
            try
            {
 
                var result = await _serviceHolder.StateService.Provinces(Parameters);
                return OkResult("لیست استان ها", result, result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet("Regions")]
        public async Task<IActionResult> Regions(string cityId )
        {
            try
            {
                var result = await _serviceHolder.StateService.Regions(Parameters ,cityId);
                return OkResult("لیست محله ها", result, result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
