using System;

namespace API.DTO;

public class LoginDTO
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
}
