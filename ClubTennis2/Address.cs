using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubTennis2
{
    public class Address
    {
        public readonly string streetAddress;
        public readonly string city;
        public readonly int postalCode;

        public Address(string streetAddress, string city, int postalCode)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.postalCode = postalCode;
        }
    }
}
