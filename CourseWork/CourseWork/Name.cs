using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Name
    {
        public Name()
        {

        }

        public Name(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        override public string  ToString()
        {           
            return FirstName + " " + MiddleName + " " + LastName; ;
        }
    }
}
