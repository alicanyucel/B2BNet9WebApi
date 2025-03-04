
using B2B.Core.Entities;

namespace B2B.Entities.Dtos;

public class UserForRegister:IDto
{
    public string Name {  get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
