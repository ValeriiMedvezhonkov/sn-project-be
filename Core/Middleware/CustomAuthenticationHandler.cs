using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using sn_project_be.Core.Interfaces;

namespace sn_project_be.Core.Middleware;

public class BasicAuthenticationOptions : AuthenticationSchemeOptions
{
}

public class CustomJwtValidationResponse
{
    public AuthenticateResult AuthenticateResult  { get; set; }
    public string? UserId { get; set; }
}

public class CustomAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOptions>
{
    private readonly IJwtUtils _jwtUtils;
    
    public CustomAuthenticationHandler(
        IOptionsMonitor<BasicAuthenticationOptions> options, 
        ILoggerFactory logger, 
        UrlEncoder encoder, 
        ISystemClock clock, 
        IJwtUtils jwtUtils)
        : base(options, logger, encoder, clock)
    {
        _jwtUtils = jwtUtils;
    }   
    
    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey("Authorization"))
            return AuthenticateResult.Fail("Unauthorized");
        
        string authorizationHeader = Request.Headers["Authorization"];
        if (string.IsNullOrEmpty(authorizationHeader))
        {
            return AuthenticateResult.NoResult();
        }

        if (!authorizationHeader.StartsWith("bearer", StringComparison.OrdinalIgnoreCase))
        {
            return AuthenticateResult.Fail("Unauthorized");
        }
 
        var token = authorizationHeader.Substring("bearer".Length).Trim();
        if (string.IsNullOrEmpty(token))
        {
            return AuthenticateResult.Fail("Unauthorized");
        }
 
        try
        {
            var jwtResponse = await ValidateToken(token);
            Context.Items["UserId"] = jwtResponse.UserId;
            return jwtResponse.AuthenticateResult;
        }
        catch (Exception ex)
        {
            return AuthenticateResult.Fail(ex.Message);
        }
    }
    
    private async Task<CustomJwtValidationResponse> ValidateToken(string token)
    {
        var jwtResponse = _jwtUtils.ValidateJwtToken(token);
        if (jwtResponse == null)
        {
            return new CustomJwtValidationResponse()
            {
                UserId = null,
                AuthenticateResult = AuthenticateResult.Fail("Unauthorized")
            };
        }
        
        var identity = new ClaimsIdentity(jwtResponse.Claims, Scheme.Name);
        var principal = new System.Security.Principal.GenericPrincipal(identity, null);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);
        var resp = new CustomJwtValidationResponse()
        {
            UserId = jwtResponse.UserId,
            AuthenticateResult = AuthenticateResult.Success(ticket)
        };
        return resp;
    }
}