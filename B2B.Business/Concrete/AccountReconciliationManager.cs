using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class AccountReconciliationManager:IAccountReconciliationService
{
    private readonly IAccountReconciliationDal _accountReconciliationDal; 
    public AccountReconciliationManager(IAccountReconciliationDal accountReconciliationDal)
    {
        _accountReconciliationDal= accountReconciliationDal;
    }
}
