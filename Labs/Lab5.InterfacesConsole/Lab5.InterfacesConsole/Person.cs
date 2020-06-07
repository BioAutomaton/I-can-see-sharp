using System;

namespace Lab5.InterfacesConsole
{

    class Person : IRetirement, ISalary
    {
        public Random r = new Random();

        private protected Name name;
        private protected int age;
        private protected int salary;
        private protected int yearsOfExperience;
        private protected bool retired;


        public int Salary { get => salary; set => salary = value; }
        public int YearsOfExperience { get => yearsOfExperience; set => yearsOfExperience = value; }
        public Name Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Retired { get => this.Retired; set => this.Retired = value; }

        public Person()
        {
            name = new Name("John", "James", "Doe");
            Age = r.Next(20, 60);
            salary = 8000 + 1000 * r.Next(0,23);
            yearsOfExperience = this.Age - 18;
            Retired = false;
        }

        public Person(Name name, int age, int salary, int yearsOfExp, bool retired)
        {
            Name = name;
            Age = age;
            Salary = salary;
            YearsOfExperience = yearsOfExp;
            Retired = retired;
        }

        public void Retire()
        {
            this.Retired = true;
        }

        public bool isRetired()
        {
            return this.Retired;
        }

        public int GetSalary()
        {
            return this.Salary;
        }

        public void Raise(UInt16 amount)
        {
            this.Salary += amount;
        }
    }
}
