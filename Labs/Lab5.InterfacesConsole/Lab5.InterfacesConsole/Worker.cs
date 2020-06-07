using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.InterfacesConsole
{
    class Worker : Person
    {
        private protected string profile;
        public string Profile { get => profile; set => profile = value; }

        public Worker()
        {
            profile = WorldInfo.Profiles[r.Next(0, 3)];
        }

        public Worker(string profile, Name name, int age, int salary, int yearsOfExp, bool retired) : base (name,age,salary,yearsOfExp,retired)
        {
            this.Profile = profile;
        }
    }
}

