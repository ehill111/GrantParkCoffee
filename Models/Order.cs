using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrantParkCoffeeShop2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderInstructions { get; set; }
        public double OrderAmountTotal { get; set; }
        public bool OrderPending { get; set; }
        public bool OrderFulfilled { get; set; }
    }
}
