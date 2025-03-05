using B2B.Core.Entities.Concrete;
using B2B.Core.Extensions;
using B2B.Core.Utilities.Security.Encryciption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace B2B.Core.Utilities.Security.Jwt;

public class JwtHelper : ITokenHelper
{
    public IConfiguration Configuration { get; }
    private TokenOptions _tokenOptions;
    DateTime _accessTokenExpiration;
    public JwtHelper(IConfiguration configuration)
    {
        Configuration = configuration;
        _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
    }
    public AcccessToken CreateToken(User user, List<OperationClaim> operationClaims, int companyId)
    {
        _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
        var singingCredentials = SigningCredentialsHelper.CreateSigningCredintials(securityKey);
        var jwt = CreateSecurityKeyToken(_tokenOptions, user, singingCredentials, operationClaims, companyId);
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var token = jwtSecurityTokenHandler.WriteToken(jwt);
        return new AcccessToken
        {
            Token = token,
            Expiration = _accessTokenExpiration,
            CompanyId = companyId
        };
    }
    public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims, int companyId)
    {
        var jwt = new JwtSecurityToken(
            issuer: tokenOptions.Issuer,
            audience: tokenOptions.Audience,
            expires: _accessTokenExpiration,
            notBefore: DateTime.Now,
            claims: SetClaims(user, operationClaims, companyId),
            signingCredentials: signingCredentials
            );

        return jwt;
    }
    private IEnumerable<Claim> SetClaims(User user,List<OperationClaim>operationClaims,int companyId)
    {
        var claims = new List<Claim>();
        claims.AddNameIdentifier(user.Id.ToString());
        claims.AddEmail(user.Email);
        claims.AddName($"{user.Name}");
        claims.AddRoles(operationClaims.Select(c=>c.Name).ToArray());
        claims.AddCompany(companyId.ToString());
        return claims;
    }
}
