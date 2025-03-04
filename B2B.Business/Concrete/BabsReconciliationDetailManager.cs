using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class BabsReconciliationDetailManager:IBabsReconciliationDetailService
{
    private readonly IBabsReconciliationDetailDal _babsReconciliationDetailDal;
    public BabsReconciliationDetailManager(IBabsReconciliationDetailDal babsReconciliationDetailDal)
    {
        _babsReconciliationDetailDal = babsReconciliationDetailDal;
    }
}
