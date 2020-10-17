using GrantParkCoffeeShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.ViewsOfShop
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }
        public List<Product> allProducts()
        {
            _products = new List<Product>();
            return _products;
        }






















    }
}
