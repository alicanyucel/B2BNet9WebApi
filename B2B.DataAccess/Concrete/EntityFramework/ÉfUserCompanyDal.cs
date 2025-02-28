

using B2B.Core.DataAccess.EntityFramework;
using B2B.Core.Entities.Concrete;
using B2B.DataAccess.Abstract;
using B2B.DataAccess.Concrete.EntityFramework.Context;

namespace B2B.DataAccess.Concrete.EntityFramework;

internal class ÉfUserCompanyDal:EfEntityRepositoryBase<UserCompany,ContextDb>,IUserCompanyDal
{
}
