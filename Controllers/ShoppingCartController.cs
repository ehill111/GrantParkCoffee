using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantParkCoffeeShop2.Helpers;
using GrantParkCoffeeShop2.Models;
using GrantParkCoffeeShop2.ViewsOfShop;
using Microsoft.AspNetCore.Mvc;

namespace GrantParkCoffeeShop2.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.ProductPrice * item.Quantity);

            return View();
        }
        private int isExist(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.Equals(id))
                {
                    return i;
                }
            } 
            return -1;
        }
        public IActionResult Buy(string id)
        {
            ProductViewModel productViewModel = new ProductViewModel(); 
            if(SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = productViewModel.find(id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if(index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = productViewModel.find(id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
    }
}
