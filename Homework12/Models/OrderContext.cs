using Microsoft.EntityFrameworkCore;

namespace Homework12.Models
{
public class OrderContext : DbContext
{
    public OrderContext(DbContextOptions<OrderContext> options)
        : base(options)
    {
        this.Database.EnsureCreated(); //自动建库建表
    }
    public DbSet<Order> Orders { get; set; }

    public DbSet<Goods> Goods { get; set; }
    public DbSet<Client> Clients { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }
}
}