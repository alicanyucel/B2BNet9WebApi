

namespace B2B.Core.Utilities.Security.Jwt;

public class AcccessToken
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
    public int CompanyId {  get; set; }
}
