using ApiGateway.Core.Models;

namespace Products.Api.Models;

public class Product : EntityBase
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}
