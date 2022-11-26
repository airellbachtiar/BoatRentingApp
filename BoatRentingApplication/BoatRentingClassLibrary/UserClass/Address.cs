using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public class Address
    {
        public Address(string streetName, string zipCode, int houseNumber, string city)
        {
            StreetName = streetName;
            ZipCode = zipCode;
            HouseNumber = houseNumber;
            City = city;
        }
        public string StreetName { get; set; }
        public string ZipCode { get; set; }
        public int HouseNumber { get; set; }
        public string City { get; set; }
    }
}
