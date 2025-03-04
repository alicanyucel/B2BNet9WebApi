
using Autofac;
using B2B.Business.Abstract;
using B2B.Business.Concrete;
using B2B.DataAccess.Abstract;
using B2B.DataAccess.Concrete.EntityFramework;

namespace B2B.Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule:Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<CompanyManager>().As<ICompanyService>();
        builder.RegisterType<EfCompanyDal>().As<ICompanyDal>();
    }
}
