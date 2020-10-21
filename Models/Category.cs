<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Display(Name = "Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
=======
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewGrantParkCoffeeShop.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
>>>>>>> 268b7ed4cf0119792e2fd212ac53f1077c1a4150
