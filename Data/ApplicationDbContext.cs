using System;
using System.Collections.Generic;
using System.Text;
using GrantParkCoffeeShop2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrantParkCoffeeShop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductSalesHistory> ProductSalesHistory { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<RoomReservation> RoomReservation { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
    }

    
    
}
