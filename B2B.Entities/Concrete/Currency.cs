

using B2B.Core.Entities;

namespace B2B.Entities.Concrete;

public class Currency:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code {  get; set; }
}
