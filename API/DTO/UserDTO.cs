using System;

namespace API.DTO;

public class UserDTO
{
    public required string Username { get; set; }
    public required string Token { get; set; }
}
