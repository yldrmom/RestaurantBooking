using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBooking.Models
{
    public class Menu :BaseModel
    {
        public string Title { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(250)]
        public decimal Price { get; set; }

    }
}
