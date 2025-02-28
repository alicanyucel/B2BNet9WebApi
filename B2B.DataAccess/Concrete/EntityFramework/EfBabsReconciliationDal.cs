
using B2B.Core.DataAccess.EntityFramework;
using B2B.DataAccess.Abstract;
using B2B.DataAccess.Concrete.EntityFramework.Context;
using B2B.Entities.Concrete;

namespace B2B.DataAccess.Concrete;

public class EfBabsReconciliationDal:EfEntityRepositoryBase<BabsReconciliation,ContextDb>,IBabsReconciliationDal
{
}
