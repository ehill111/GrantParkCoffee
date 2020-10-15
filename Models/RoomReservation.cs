using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EnclaveGrantParkCoffeeShop.Models
{
    public class RoomReservation
    {
        public int RoomReservationId { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationStopDate { get; set; }
        public DateTime ReservationTimeStart { get; set; }
        public DateTime ReservationTimeStop { get; set; }
        public string ReservationCustomerName { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
    }
}
