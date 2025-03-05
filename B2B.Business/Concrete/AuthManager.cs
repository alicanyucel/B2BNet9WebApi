

using B2B.Business.Abstract;
using B2B.Business.Constans;
using B2B.Core.Entities.Concrete;
using B2B.Core.Utilities.Hashing;
using B2B.Core.Utilities.Result.Abstract;
using B2B.Core.Utilities.Result.Concrete;
using B2B.Core.Utilities.Security.Jwt;
using B2B.Entities.Dtos;

namespace B2B.Business.Concrete;

public class AuthManager : IAuthService
{
    private readonly IUserService _userService;
    private readonly ITokenHelper _tokenHelper;
    public AuthManager(IUserService userService,ITokenHelper tokenHelper)
    {
        _userService = userService;
        _tokenHelper = tokenHelper;
    }
    public IDataResult<AcccessToken> CreateAccessToken(User user,int companyId)
    {
        var claim = _userService.GetClaims(user, companyId);
        var accessToken=_tokenHelper.CreateToken(user,claim,companyId);
        return new SuccessDataResult<AcccessToken>(accessToken);
    }

    public IDataResult<User> Login(UserForLogin userForLogin)
    {
       var userToCheck=_userService.GetByEmail(userForLogin.Email); 
        if(userToCheck == null)
        {
            return new ErrorDataResult<User>(Messages.UserNotFound);
        }
        if(!HashingHelper.VerifyPasswordHash(userForLogin.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
        {
            return new ErrorDataResult<User>(Messages.PasswordError);
        }
        return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin);
    }

    public IDataResult<User> Register(UserForRegister userForRegister, string password)
    {
        byte[] passwordHash, passwordSalt;
        HashingHelper.CreatePasswordHash(password,out passwordHash,out passwordSalt);
        var user = new User()
        {
            Email = userForRegister.Email,
            AddedAt = DateTime.Now,
            IsActive = true,
            MailConfirm = false,
            MailConfirmDate = DateTime.Now,
            MailConfirmValue = Guid.NewGuid().ToString(),
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Name = userForRegister.Name,
        };
        _userService.Add(user);
        return new SuccessDataResult<User>(user, Messages.UserRegistered);
    }
    public IResult UserExists(string email)
    {
        if(_userService.GetByEmail(email) != null)
        {
            return new ErrorResult(Messages.UserAllReadyExists);
        }
        return new SuccessResult();
    }
}
