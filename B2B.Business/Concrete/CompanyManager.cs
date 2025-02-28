
using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;
using B2B.Entities.Concrete;


namespace B2B.Business.Concrete;

public class CompanyManager:ICompanyService
{
    public readonly ICompanyDal _companyDal;
    public CompanyManager(ICompanyDal companyDal)
    {
        _companyDal = companyDal;
    }

    public List<Company> GetList()
    {
        return _companyDal.GetList();
    }

}
