using ApiGateway.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Products.Api.Models;
using Users.Api.Models;

namespace ApiGateway.Infra.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    DbSet<User> Users { get; set; }
    DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new UserMapping());
        modelBuilder.ApplyConfiguration(new ProductMapping());
    }
}
