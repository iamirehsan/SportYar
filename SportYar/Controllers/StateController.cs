using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportYar.Base;
using SportYar.Infrastructure.Base;
using SportYar.Service.Interfaces;

namespace SportYar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ApiControllerBase
    {
        private readonly IServiceHolder _serviceHolder;

        public StateController(IServiceHolder serviceHolder)
        {
            _serviceHolder = serviceHolder;
        }
        [HttpGet]
        public async Task<IActionResult> Cities(string provinceId , string name) {
            try
            {
                var result = await _serviceHolder.StateService.Cities(name,provinceId);
                return OkResult("لیست شهر ها",result , result.Count());
            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
