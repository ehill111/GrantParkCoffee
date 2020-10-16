using System;
using System.Collections.Generic;
using System.Text;
using GrantParkCoffeeShop2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrantParkCoffeeShop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public object modelBuilder;

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

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<IdentityRole>()
        //        .HasData(
        //            new IdentityRole
        //            {
        //                Name = "Admin",
        //                NormalizedName = "ADMIN"
        //            }
        //        );

        //    builder.Entity<Product>().HasData(
        //           new Product

        //           {
        //               ProductId = 1,
        //               ProductType = "Food",
        //               ProductName = "Bacon, Egg, and Cheese Croissant",
        //               ProductPrice = 6.99,
        //               ProductFeatured = false,
        //               ProductOnDiscountSale = false,
        //               RewardEligible = true,
        //           },
        //           new Product
        //           {
        //               ProductId = 2,
        //               ProductType = "Food",
        //               ProductName = "Chicken Salad Sandwich",
        //               ProductPrice = 6.99,
        //               ProductFeatured = true,
        //               ProductOnDiscountSale = false,
        //               RewardEligible = true,
        //           },
        //            new Product
        //            {
        //                ProductId = 3,
        //                ProductType = "Food",
        //                ProductName = "Creamy Cheese Grits",
        //                ProductPrice = 2.99,
        //                ProductFeatured = false,
        //                ProductOnDiscountSale = false,
        //                RewardEligible = true,
        //            },
        //             new Product
        //             {
        //                 ProductId = 4,
        //                 ProductType = "Food",
        //                 ProductName = "Spinach Salad",
        //                 ProductPrice = 6.99,
        //                 ProductFeatured = false,
        //                 ProductOnDiscountSale = false,
        //                 RewardEligible = true,
        //             },
        //              new Product
        //              {
        //                  ProductId = 5,
        //                  ProductType = "Dessert",
        //                  ProductName = "Banana Nut Bread",
        //                  ProductPrice = 2.99,
        //                  ProductFeatured = false,
        //                  ProductOnDiscountSale = false,
        //                  RewardEligible = true,
        //              },
        //               new Product
        //               {
        //                   ProductId = 6,
        //                   ProductType = "Dessert",
        //                   ProductName = "Chocolate Chip Skone",
        //                   ProductPrice = 2.99,
        //                   ProductFeatured = false,
        //                   ProductOnDiscountSale = false,
        //                   RewardEligible = true,
        //               },
        //                new Product
        //                {
        //                    ProductId = 7,
        //                    ProductType = "Dessert",
        //                    ProductName = "Blueberry Muffin",
        //                    ProductPrice = 2.99,
        //                    ProductFeatured = false,
        //                    ProductOnDiscountSale = false,
        //                    RewardEligible = true,
        //                },
        //                 new Product
        //                 {
        //                     ProductId = 8,
        //                     ProductType = "Beverage",
        //                     ProductName = "Coffee",
        //                     ProductPrice = 2.49,
        //                     ProductFeatured = false,
        //                     ProductOnDiscountSale = false,
        //                     RewardEligible = true,
        //                 },
        //                 new Product
        //                 {
        //                     ProductId = 9,
        //                     ProductType = "Beverage",
        //                     ProductName = "Juice",
        //                     ProductPrice = 2.99,
        //                     ProductFeatured = false,
        //                     ProductOnDiscountSale = false,
        //                     RewardEligible = true,
        //                 },
        //                  new Product
        //                  {
        //                      ProductId = 10,
        //                      ProductType = "Beverage",
        //                      ProductName = "Water",
        //                      ProductPrice = 1.49,
        //                      ProductFeatured = false,
        //                      ProductOnDiscountSale = false,
        //                      RewardEligible = false
        //                  }
        //                  );

        //}

    }

}







            


    
    

