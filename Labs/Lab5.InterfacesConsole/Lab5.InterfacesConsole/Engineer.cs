namespace Lab5.InterfacesConsole
{
    class Engineer : Person
    {
        private protected string category;

        public string Category { get => category; set => category = value; }

        public Engineer()
        {
            Category = WorldInfo.EngineerCategories[r.Next(0, WorldInfo.EngineerCategories.Length-1)];
        }

        public Engineer(string category, Name name, int age, int salary, int yearsOfExp, bool retired) : base(name, age, salary, yearsOfExp, retired)
        {
            this.Category = category;
        }
    }
}
