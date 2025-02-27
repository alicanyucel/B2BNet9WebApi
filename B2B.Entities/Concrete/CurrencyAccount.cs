
using B2B.Core.Entities;

namespace B2B.Entities.Concrete;

public  class CurrencyAccount:IEntity
{
    public int Id { get; set; }
    public int CompanyId {  get; set; }
    public string Code {  get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string? TaxDepartment {  get; set; }
    public string? TaxIdNumber {  get; set; }
    public string? IdentityNumber {  get; set; }
    public string? Email {  get; set; }
    public DateTime? Authorized { get; set; } 
    public DateTime? AddedAt { get; set; }
    public bool IsActive {  get; set; }
}
