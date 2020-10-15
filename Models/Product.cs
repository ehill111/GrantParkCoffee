using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnclaveGrantParkCoffeeShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductFeatured { get; set; }
        public bool ProductOnDiscountSale { get; set; }
        public bool RewardEligible { get; set; }
    }
}
