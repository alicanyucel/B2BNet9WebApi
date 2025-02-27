
using B2B.Core.Entities.Concrete;
using B2B.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace B2B.DataAccess.Concrete.EntityFramework.Context;

public class ContextDb:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-L6NJT48\SQLEXPRESS;Database=eReconciliationDb;Integrated Security=true");
    }

    public DbSet<AccountReconciliationDetail> AccountReconciliationDetails { get; set; }
    public DbSet<AccountReconciliation> AccountReconciliations { get; set; }
    public DbSet<BabsReconciliation> BabsReconciliations { get; set; }  
    public DbSet<BabsReconcliationDetails> BabsReconcliationDetails { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Currency> Currencies{ get; set; }
    public DbSet<CurrencyAccount> CurrenciesAccounts { get; set; }
    public DbSet<MailParameter> MailParameters { get; set; }
    public DbSet<OpetationClaim> OpetationClaims { get; set; }
    public DbSet<UserCompany> UserCompanies { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperatioClaims { get; set; }


}
