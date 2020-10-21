using System.ComponentModel.DataAnnotations;

namespace NewGrantParkCoffeeShop.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ProductId { get; set; }
<<<<<<< HEAD
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Product Price")]
        public double UnitPrice { get; set; }
        [Display(Name = "Product Featured")]
        public bool ProductFeatured { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Product On Discount Sale")]
        public bool ProductOnSale { get; set; }
        [Display(Name = "Reward Eligible")]
=======
        [Display(Name = "Product Type", Order = -9)]
        public string ProductType { get; set; }
        [Display(Name = "Name", Order = -9)]
        public string ProductName { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Price", Order = -9)]
        public double? UnitPrice { get; set; }
        [Required, StringLength(10000), Display(Name = "Featured Item!", Order = -9), DataType(DataType.MultilineText)]
        public bool ProductFeatured { get; set; }
        [Display(Name = "On Sale!", Order = -9)]
        public bool ProductOnSale { get; set; }
        [Display(Name = "Reward Eligible", Order = -9)]
>>>>>>> 268b7ed4cf0119792e2fd212ac53f1077c1a4150
        public bool RewardEligible { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}