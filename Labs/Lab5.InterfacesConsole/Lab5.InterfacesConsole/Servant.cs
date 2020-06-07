namespace Lab5.InterfacesConsole
{
    class Servant : Person
    {
        private protected uint averageTips;
        public uint AverageTips { get => averageTips; set => averageTips = value; }
        public Servant()
        {
            this.AverageTips = (uint)r.Next(1000, 10000);
        }

        public Servant(uint avgTips, Name name, int age, int salary, int yearsOfExp, bool retired) : base (name, age, salary, yearsOfExp, retired)
        {
            this.AverageTips = avgTips;
        }
    }


}
