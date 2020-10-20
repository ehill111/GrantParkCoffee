using System.Data.Entity;
namespace NewGrantParkCoffeeShop.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("NewGrantParkCoffeeShop")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSalesHistory> ProductSalesHistories { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}