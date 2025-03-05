using Microsoft.IdentityModel.Tokens;

namespace B2B.Core.Utilities.Security.Encryciption;

public class SigningCredentialsHelper
{
    public static SigningCredentials CreateSigningCredintials(SecurityKey securityKey)
    {
        return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
    }
}
