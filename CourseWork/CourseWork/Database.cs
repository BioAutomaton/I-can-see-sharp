using System;
using System.Collections.Generic;
using System.Text.Json;

namespace CourseWork
{
    class Database
    {
        private List<Client> listOfClients;

        internal List<Client> ListOfClients { get => listOfClients; set => listOfClients = value; }

        public Database()
        {
            listOfClients = new List<Client>();
        }


        public void AddClient(Name name, Address address, string numberOfContract, int sumOfDeposit, DateTime contractDate, int daysOfContractTerm)
        {
            listOfClients.Add(new Client(name, address, numberOfContract, sumOfDeposit, contractDate, daysOfContractTerm));
        }

        public void AddClient(Client client)
        {
            listOfClients.Add(client);
        }

        public string Serialize()
        {
            return JsonSerializer.Serialize(listOfClients);
        }

        public bool Deserialize(string json)
        {
            try
            {
                listOfClients = JsonSerializer.Deserialize<List<Client>>(json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeserializeAppend(string json)
        {
            try
            {
                listOfClients.AddRange(JsonSerializer.Deserialize<List<Client>>(json));
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        public Database SearchByName(string name)
        {
            Database temp = new Database();
            foreach (Client client in this.listOfClients)
            {
                if (client.Name.ToString().ToLower().Contains(name.ToLower()))
                {
                    temp.listOfClients.Add(client);
                }
            }
            return temp;
        }

        public Database SearchBySum(int depositSum)
        {
            Database temp = new Database();
            foreach (Client client in this.listOfClients)
            {
                if (client.SumOfDeposit >= depositSum)
                {
                    temp.listOfClients.Add(client);
                }
            }
            return temp;
        }
        public Database SearchByTerm(int days)
        {
            Database temp = new Database();
            foreach (Client client in this.listOfClients)
            {
                if (client.DaysOfContractTerm >= days)
                {
                    temp.listOfClients.Add(client);
                }
            }
            return temp;
        }        
        public Database SearchByContract(string numberOfContract)
        {
            Database temp = new Database();
            foreach (Client client in this.listOfClients)
            {
                if (client.NumberOfContract.Equals(numberOfContract))
                {
                    temp.listOfClients.Add(client);
                }
            }
            return temp;
        }

        public Database DeleteByLastName(string name)
        {
            Database temp = new Database();
            foreach (Client client in this.listOfClients)
            {
                if (!client.Name.LastName.ToLower().Equals(name.ToLower()))
                {
                    temp.listOfClients.Add(client);
                }
            }
            return temp;
        }
        public Database DeleteByContract(string numberOfContract)
        {
            Database temp = new Database();
            foreach (Client client in this.listOfClients)
            {
                if (!client.NumberOfContract.Equals(numberOfContract))
                {
                    temp.listOfClients.Add(client);
                }
            }
            return temp;
        }
    }
}

