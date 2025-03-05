

using B2B.Business.Abstract;
using B2B.Business.Constans;
using B2B.Core.Entities.Concrete;
using B2B.Core.Utilities.Result.Abstract;
using B2B.Core.Utilities.Result.Concrete;
using B2B.Core.Utilities.Security.Jwt;
using B2B.Entities.Dtos;

namespace B2B.Business.Concrete;

public class AuthManager : IAuthService
{
    private readonly IUserService _userService;
    public AuthManager(IUserService userService)
    {
        _userService = userService;
    }
    public IDataResult<AcccessToken> CreateAccessToken(User user)
    {
       
    }

    public IDataResult<User> Login(UserForLogin userForLogin)
    {
       var userToCheck=_userService.GetByEmail(userForLogin.Email); 
        if(userToCheck == null)
        {
            return new ErrorDataResult<User>(Messages.UserNotFound);
        }

    }

    public IDataResult<User> Register(UserForRegister userForRegister, string password)
    {
        throw new NotImplementedException();
    }

    public IResult UserExists(string email)
    {
        throw new NotImplementedException();
    }
}
