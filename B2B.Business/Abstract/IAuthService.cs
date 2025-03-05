using B2B.Core.Entities.Concrete;
using B2B.Core.Utilities.Result.Abstract;
using B2B.Core.Utilities.Security.Jwt;
using B2B.Entities.Dtos;

namespace B2B.Business.Abstract;

public interface IAuthService
{
    IDataResult<User> Register(UserForRegister userForRegister, string password);
    IDataResult<User> Login(UserForLogin userForLogin);
    IResult UserExists(string email);
    IDataResult<AcccessToken> CreateAccessToken(User user,int companyId);
}
