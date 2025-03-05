
using Autofac;
using B2B.Business.Abstract;
using B2B.Business.Concrete;
using B2B.Core.Utilities.Security.Jwt;
using B2B.DataAccess.Abstract;
using B2B.DataAccess.Concrete;
using B2B.DataAccess.Concrete.EntityFramework;

namespace B2B.Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule:Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CompanyManager>().As<ICompanyService>();
        builder.RegisterType<EfCompanyDal>().As<ICompanyDal>();

        builder.RegisterType<CurrencyAccountManager>().As<ICurrencyAccountService>();
        builder.RegisterType<EfCurrencyAccountDal>().As<ICurrencyAccountDal>();

        builder.RegisterType<MailParameterManager>().As<IMailParameterService>();
        builder.RegisterType<EfMailParameterDal>().As<IMailParameterDal>();

        builder.RegisterType<CurrencyManager>().As<ICurrencyService>();
        builder.RegisterType<EfCurrencyDal>().As<ICurrencyDal>();

        builder.RegisterType<BabsReconciliationDetailManager>().As<IBabsReconciliationDetailService>();
        builder.RegisterType<EfBabsReconciliationDetailDal>().As<IBabsReconciliationDetailDal>();

        builder.RegisterType<BabsReconciliationManager>().As<IBabsReconciliationService>();
        builder.RegisterType<EfBabsReconciliationDal>().As<IBabsReconciliationDal>();

        builder.RegisterType<AccountReconciliationDetailManager>().As<IAccountReconciliationDetailService>();
        builder.RegisterType<EfAccountReconciliationDetailDal>().As<IAccountReconciliationDetailDal>();

        builder.RegisterType<AuthManager>().As<IAuthService>();
        builder.RegisterType<JwtHelper>().As<ITokenHelper>();

        builder.RegisterType<UserManager>().As<IUserService>();
        builder.RegisterType<EfUserDal>().As<IUserDal>();

        builder.RegisterType<AccountReconciliationManager>().As<IAccountReconciliationService>();
        builder.RegisterType<EfAccountReconciliationDal>().As<IAccountReconciliationDal>();
        
    }
}
