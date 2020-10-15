using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
    }
}
