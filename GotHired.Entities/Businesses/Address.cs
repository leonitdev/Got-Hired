using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotHired.Entities.Businesses
{
    public class Address
    {
        public Address(string city, string street, int postalCode)
        {
            City = city;
            Street = street;
            PostalCode = postalCode;
        }

        public string City { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
    }

}
