using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReserver.Server.Client.Models
{
    class Booking
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public int Visitors { get; set; }
        public DateTime Time { get; set; }
    }
}
