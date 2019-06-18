using System;
using System.Collections.Generic;
using System.Text;

namespace SmartReserver.Server.Client.Models
{
    class User
    {
        public string Id { get; set; }

        public string Token { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string AvatarUrl { get; set; }

        public string PhoneNumber { get; set; }
    }
}
