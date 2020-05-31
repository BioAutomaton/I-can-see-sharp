using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{

    public class Address
    {
        private string country, state, city, street;

        public string Country { get => country; set => country = value; }
        public string State { get => state; set => state = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }

        public Address()
        {

        }

        public Address (string country, string state, string city, string street)
        {
            this.country = country;
            this.state = state;
            this.city = city;
            this.street = street;
        }


        public override string ToString()
        {
            return country + ", " + city + ", " + state + ", " + street;
        }
    }
}
