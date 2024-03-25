using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBooking.Models
{
    public class Order : BaseModel
    {
        public Menu Menu { get; set; }
        public int MenuId { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
        public Reservation Reservation { get; set; }
        public int ReservationId { get; set; }


    }
}
