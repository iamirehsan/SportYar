using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace SportYar.Base
{
    [Authorize]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {

        protected string AccessToken => GetToken(Request);

        protected virtual string UserName => GetClaim(AccessToken, "userName");
        protected virtual string UserId => GetClaim(AccessToken, "userId");


        protected ApiControllerBase()
        {
        }
        #region responses 
        [NonAction]
        public BadRequestObjectResult BadRequest(string message)
        {
            return BadRequest(new { Message = message });
        }

        [NonAction]
        public NotFoundObjectResult NotFound(string message)
        {
            return NotFound(new { Message = message });
        }

        [NonAction]
        protected virtual IActionResult OkResult()
        {
            return OkResult("", null);
        }

        [NonAction]
        protected virtual IActionResult OkResult(string message)
        {
            return OkResult(message, null);
        }

        [NonAction]
        protected virtual IActionResult OkContentResult(object content)
        {
            return OkResult("", content);
        }

        [NonAction]
        protected virtual IActionResult OkResult(string message, object content)
        {
            return Ok(new ResponseMessage(message, content));
        }

        [NonAction]
        protected virtual IActionResult OkResult(string message, object content, int total)
        {
            return Ok(new ResponseMessage(message, content, total));
        }
        private string GetClaim(string jwtToken, string claimName)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtTokenObject = tokenHandler.ReadJwtToken(jwtToken);

            // read the claims
            var claims = jwtTokenObject.Claims;

            return claims.FirstOrDefault(x => x.Type == claimName).ToString();
        }

        private string GetToken(HttpRequest request)
        {
            var token = request.Headers.ContainsKey("Authorization")
                                                                        ? request.Headers["Authorization"].ToString().Split(" ")[1]
                                                                        : string.Empty;
            return token;
        }
        #endregion

        public class RequestConfig
        {
            public static RequestConfig Default => new RequestConfig();

            /// <inheritdoc />
            public RequestConfig(bool returnContentOnly = false)
            {
                ReturnContentOnly = returnContentOnly;
            }

            public bool ReturnContentOnly { get; set; }

            public bool ReturnActionOutputOnly { get; set; }
        }
    }
}
