

using B2B.Core.Entities.Concrete;

namespace B2B.Core.Utilities.Security.Jwt;

public interface ITokenHelper
{
    AcccessToken CreateToken(User user, List<OperationClaim> operationClaims,int companyId);


}
