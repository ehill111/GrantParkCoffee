using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public bool ProductFeatured { get; set; }
        public bool ProductOnDiscountSale { get; set; }
        public bool RewardEligible { get; set; }
    }
}
