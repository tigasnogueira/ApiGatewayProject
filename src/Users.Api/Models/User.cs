using ApiGateway.Core.Models;

namespace Users.Api.Models;

public class User : EntityBase
{
    public string Name { get; set; }
    public string Email { get; set; }
}
