using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnclaveGrantParkCoffeeShop.Models
{
    public class Customer
    {   
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public string CustomerUserName { get; set; }
        public string CustomerPassword { get; set; }
        public int RewardPointsBalance { get; set; }
    }
}
