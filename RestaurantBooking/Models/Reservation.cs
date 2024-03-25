using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBooking.Models
{
    public class Reservation : BaseModel
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public string Note { get; set; }
        [MaxLength(250)]
        public DateTime ReservationDate { get; set; }
    }

}
