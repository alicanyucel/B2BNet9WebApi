using B2B.Core.Entities;

namespace B2B.Entities.Dtos;

public class UserForLogin:IDto
{
    public string Email {  get; set; }
    public string Password { get; set; }
}
