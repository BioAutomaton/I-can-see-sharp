using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.InterfacesConsole
{
    public class Name
    {
        public Name()
        {

        }

        public Name(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        override public string ToString()
        {
            return FirstName + " " + MiddleName + " " + LastName; ;
        }
    }
}
