using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrantParkCoffeeShop2.Helpers;
using GrantParkCoffeeShop2.Models;
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

    }
}
