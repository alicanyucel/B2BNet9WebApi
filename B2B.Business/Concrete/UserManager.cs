

using B2B.Business.Abstract;
using B2B.Core.Entities.Concrete;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;
public class UserManager : IUserService
{
    private IUserDal _userDal;
    public UserManager(IUserDal userDal)
    {
        _userDal = userDal; 
    }
    public void Add(User user)
    {
        _userDal.Add(user);
    }

    public User GetByEmail(string email)
    {
        return _userDal.Get(p => p.Email == email);

    }
    public List<OperationClaim> GetClaims(User user, int companyId)
    {
        return _userDal.GetClaims(user, companyId); 
    }
}
