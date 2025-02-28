
using B2B.Business.Abstract;
using B2B.Business.Constans;
using B2B.Core.Utilities.Result.Abstract;
using B2B.Core.Utilities.Result.Concrete;
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

    public IResult Add(Company company)
    {
      _companyDal.Add(company);
      return new SuccessResult(Messages.AddedCompany);
    }

    public IDataResult<List<Company>> GetList()
    {
        return new SuccessDataResult<List<Company>>(_companyDal.GetList());
    }
}
