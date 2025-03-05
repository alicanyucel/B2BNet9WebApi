

using B2B.Core.Entities.Concrete;

namespace B2B.Business.Abstract;

public interface IUserService
{
    List<OperationClaim> GetClaims(User user,int companyId);
    void Add(User user);
    User GetByEmail(string email);
}

