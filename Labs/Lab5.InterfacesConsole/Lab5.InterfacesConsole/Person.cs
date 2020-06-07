using System;

namespace Lab5.InterfacesConsole
{

    interface IRetirement
    {

    }

    class Person
    {
        public Random r = new Random();

        private Name name;
        private int age;
        private int salary;
        private int yearsOfExperience;
        private string profile;

        public string Profile { get => profile; set => profile = value; }
        public int Salary { get => salary; set => salary = value; }
        public int YearsOfExperience { get => yearsOfExperience; set => yearsOfExperience = value; }
        public Name Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person()
        {
            name = new Name("John", "James", "Doe");
            Age = r.Next(20, 60);
            salary = 8000 + 1000 * r.Next(0,23);
            yearsOfExperience = this.Age - 18;
            profile = WorldInfo.Profiles[r.Next(0, 3)];
        }

        public Person(Name name, int age, int salary, int yearsOfExp, string profile)
        {
            Name = name;
            Age = age;
            Salary = salary;
            YearsOfExperience = yearsOfExp;
            Profile = profile;
        }
    }
}
