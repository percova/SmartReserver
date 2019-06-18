using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReserver.Server.Client.Models
{
    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }
        public int AveragePrice { get; set; }
        public string DefaultPicture { get; set; }
        public string Street { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string CheckInTime { get; set; }
        public string CheckOutTime { get; set; }
        public List<string> Pictures { get; set; }
    }
}
