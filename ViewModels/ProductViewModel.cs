﻿using GrantParkCoffeeShop2.Data;
using GrantParkCoffeeShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.ViewsOfShop
{
    public class ProductViewModel
    {
        public List<Product> Product { get; set; }//Declared list.
        public int Id { get; private set; }

        public List<Product> findAllProducts()//Method to see list.  
        {
            var products = db.Product.ToList();
            return View(products);
        }

        public Product find(string id)//Method to search by Id.
        {
            List<Product> products = findAllProducts();
            var foundProduct = products.Where(a => a.ProductId == Id).FirstOrDefault();//Check "Id" if problem.
            return foundProduct;
        }





















        //}
    }
