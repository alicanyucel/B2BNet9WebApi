using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class BabsReconciliationManager:IBabsReconciliationService
{
    private readonly IBabsReconciliationDal _babsReconciliationDal;
    public BabsReconciliationManager(IBabsReconciliationDal babsReconciliationDal)
    {
        _babsReconciliationDal= babsReconciliationDal;
    }
}
