using System.Collections.Generic;
using System.Data.Entity;

namespace NewGrantParkCoffeeShop.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Food"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Dessert"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Beverage"
                },
            };

            return categories;
        }

