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
        [Display(Name = "Product Type", Order = -9)]
        public string ProductName { get; set; }
        [Display(Name = "Product Name", Order = -9)]
        public double ProductPrice { get; set; }
        [Display(Name = "Product Price", Order = -9)]
        public bool ProductFeatured { get; set; }
        [Display(Name = "Product Featured", Order = -9)]
        public bool ProductOnDiscountSale { get; set; }
        [Display(Name = "Product On Discount Sale", Order = -9)]
        public bool RewardEligible { get; set; }
        //[Display(Name = "Reward Eligible", Order = -9)]
    }
    
}
