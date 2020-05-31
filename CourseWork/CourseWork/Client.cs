using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace CourseWork
{
    [Serializable]
    public class Client
    {

        //public string Address { get; set; }
        public Address Address { get; set; }
        public string NumberOfContract { get; set; }
        public int SumOfDeposit { get; set; }
        public DateTime ContractDate { get; set; }
        public int DaysOfContractTerm { get; set; }
        public Name Name { get; set; }

        public Client()
        {
            NumberOfContract = GenerateContractNumber();
            ContractDate = DateTime.Now;
        }


        public Client(Name name, Address address, string numberOfContract, int sumOfDeposit, DateTime contractDate,int daysOfContractTerm)
        {
            this.Name = name;
            this.Address = address;
            this.NumberOfContract = numberOfContract;
            this.SumOfDeposit = sumOfDeposit;
            this.ContractDate = contractDate;
            this.DaysOfContractTerm = daysOfContractTerm;
        }

        private string GenerateContractNumber()
        {
            Random r = new Random();
            string output = "";
            bool original;

            do
            {
                original = true;
                int temp = r.Next(1, 99999999);
                output = String.Format("{0,0:D8}", temp);

                foreach (string str in WorldInfo.ClaimedContracts)
                {
                    if (str.Equals(output))
                    {
                        original = false;
                        break;
                    }
                }

            } while (!original);

            return output;
        }
    }
}
