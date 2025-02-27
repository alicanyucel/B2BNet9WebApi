

using B2B.Core.Entities;

namespace B2B.Entities.Concrete;

public class Company:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address {  get; set; }
    public string TaskDepartment {  get; set; }
    public string? TaskIdNumber {  get; set; }
    public string IdentityNumber {  get; set; }
    public DateTime AddedAt { get; set; }
}
