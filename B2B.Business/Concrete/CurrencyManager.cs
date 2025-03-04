

using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class CurrencyManager:ICurrencyService
{
    private readonly ICurrencyDal _currencyDal;
    public CurrencyManager(ICurrencyDal currencyDal)
    {
        _currencyDal = currencyDal;
    }
}
