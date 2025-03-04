using B2B.Core.DataAccess.EntityFramework;
using B2B.Core.Entities.Concrete;
using B2B.DataAccess.Abstract;
using B2B.DataAccess.Concrete.EntityFramework.Context;

namespace B2B.DataAccess.Concrete.EntityFramework;

public class EfUserDal : EfEntityRepositoryBase<User, ContextDb>, IUserDal
{
    public List<OperationClaim> GetClaims(User user, int companyId)
    {
        using (var context = new ContextDb())
        {
            var result = from operationClaim in context.OpetationClaims
                         join userOperationClaim in context.UserOperatioClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.CompanyId == companyId && userOperationClaim.UserId == user.Id
                         select new OperationClaim
                         {
                             Id = operationClaim.Id,
                             Name = operationClaim.Name
                         };

            return result.ToList();
        }
    }
}
