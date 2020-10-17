using GrantParkCoffeeShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.ViewsOfShop
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }//Declared list.
        public int Id { get; private set; }

        public List<Product> allProducts()//Method to see list.  
        {
            _products = new List<Product>();
            return _products;
        }

        public Product find(string id)//Method to search by Id.
        {
            List<Product> products = allProducts();
            var foundProduct = products.Where(a => a.ProductId == Id).FirstOrDefault();//Check "Id" if problem.
            return foundProduct;
        }





















    }
}
