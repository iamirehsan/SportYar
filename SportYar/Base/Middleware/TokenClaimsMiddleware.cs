using Newtonsoft.Json.Linq;
using SportYar.Infrastructure.Base;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

public class TokenClaimsMiddleware  : IDisposable
{
    private readonly RequestDelegate _next;
    private TokenClaims _tokenClaims;
 

    public TokenClaimsMiddleware(RequestDelegate next)
    {
        _next = next;

    }
    public async Task InvokeAsync(HttpContext context) 
    {
        TokenClaims.Dispose();
        var token = context.Request.Headers.ContainsKey("Authorization")
                                                                      ? context.Request.Headers["Authorization"].ToString().Split(" ")[1]
                                                                      : string.Empty;

        var tokenHandler = new JwtSecurityTokenHandler();
        var jwtTokenObject = tokenHandler.ReadJwtToken(token);
        var claims = jwtTokenObject.Claims;
        var userId = claims.FirstOrDefault(x => x.Type == "userId").ToString();
        // create singleton object and set properties per request
        _tokenClaims = TokenClaims.CreateInstance(userId);

        var serviceProvider = context.RequestServices.GetService<IServiceProvider>();
        var tokenClaimsSingleton = new ServiceDescriptor(typeof(TokenClaims), _tokenClaims);

        await _next(context);
      
    }

    public void Dispose()
    {
        _tokenClaims = null;
    }
}



// read the claims


