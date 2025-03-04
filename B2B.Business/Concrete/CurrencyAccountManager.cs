

using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class CurrencyAccountManager:ICurrencyAccountService
{
    private readonly ICurrencyAccountDal _currencyAccountDal;
    public CurrencyAccountManager(ICurrencyAccountDal currencyAccountDal)
    {
        _currencyAccountDal = currencyAccountDal;
    }
}
