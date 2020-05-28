using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Blowout_Kraupp_Tyler.Models
{
    public class Client
    {
        [DisplayName("Client ID")]
        public int ClientID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        public string Zip { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }
    }
}