using B2B.Business.Abstract;
using B2B.DataAccess.Abstract;

namespace B2B.Business.Concrete;

public class MailParameterManager:IMailParameterService
{
    private readonly IMailParameterDal _mailParameterDal;
    public MailParameterManager(IMailParameterDal mailParameterDal)
    {
        _mailParameterDal = mailParameterDal;   
    }
}
