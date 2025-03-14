﻿


using B2B.Core.Entities;

namespace B2B.Entities.Concrete;

public class AccountReconciliation : IEntity
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int CurrencyAccountId { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime EndingDate { get; set; }
    public int CurrencyId { get; set; }
    public decimal CurrencyCredit {  get; set; }
    public decimal CurrencyDebit { get; set; }
    public bool IsSendEmail { get; set; }
    public DateTime? SendEmailDate { get; set; }
    public bool? IsEmaiRead { get; set; }
    public DateTime? EmailReadDate { get; set; }
    public bool? IsResultSucceed {  get; set; }
    public DateTime? ResultDate { get; set; }
    public string? ResultNote {  get; set; }
}
