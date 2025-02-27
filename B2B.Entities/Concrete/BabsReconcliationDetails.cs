
using B2B.Core.Entities;

namespace B2B.Entities.Concrete;

public  class BabsReconcliationDetails:IEntity
{ 
    public int Id { get; set; }
    public int BabsReconciliationId {  get; set; }
    public DateTime Date { get; set; }  
    public string Description {  get; set; }
    public decimal Amount {  get; set; }
}
