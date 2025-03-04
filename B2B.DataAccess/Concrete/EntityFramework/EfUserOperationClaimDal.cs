

using B2B.Core.DataAccess.EntityFramework;
using B2B.Core.Entities.Concrete;
using B2B.DataAccess.Abstract;
using B2B.DataAccess.Concrete.EntityFramework.Context;
namespace B2B.DataAccess.Concrete.EntityFramework;

public class EfUserOperationClaimDal:EfEntityRepositoryBase<UserOperationClaim,ContextDb>,IUserOperationClaimDal
{
}
