﻿
namespace B2B.Core.Entities.Concrete;

public class OpetationClaim:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime AddedAt { get; set; }
    public bool IsActive {  get; set; }

}
