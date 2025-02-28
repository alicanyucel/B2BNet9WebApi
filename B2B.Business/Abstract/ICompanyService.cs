
using B2B.Core.Utilities.Result.Abstract;
using B2B.Entities.Concrete;

namespace B2B.Business.Abstract;

public interface ICompanyService
{
    IResult Add(Company company);
    IDataResult<List<Company>> GetList();
}
