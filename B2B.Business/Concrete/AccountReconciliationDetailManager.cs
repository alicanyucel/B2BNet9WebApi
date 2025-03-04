using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class AccountReconciliationDetailManager:IAccountReconciliationDetailService
{
    private readonly IAccountReconciliationDetailDal _accountReconciliationDetailDal;
    public AccountReconciliationDetailManager(IAccountReconciliationDetailDal accountReconciliationDetailDal)
    {
        _accountReconciliationDetailDal = accountReconciliationDetailDal;
    }
}
