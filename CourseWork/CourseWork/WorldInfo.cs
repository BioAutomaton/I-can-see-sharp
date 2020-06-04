using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Policy;

namespace CourseWork
{
    static class WorldInfo
    {

        public static Country[] Countries;
        public static string[] FAQ;
        private static List<string> claimedContracts = new List<string>();

        private static string[,] searchOptions = { { "Name", "Name must contain"}, { "Contract number", "Exact number of contract" },
            { "Contract term", "Days of Contract term must exceed" }, {"Deposit sum", "Sum of deposit must exceed" } };
        private static string[,] deleteOptions = { { "Last Name", "Exact last name"}, { "Contract number", "Exact number of contract" }};
        private static string[,] editOptions = { { "Contract number", "Exact number of contract" } };

        //private static string path = "C:\\Users\\Михаил\\source\\repos\\BioAutomaton\\I-can-see-sharp\\CourseWork\\CourseWork\\";

        public static List<string> ClaimedContracts { get => claimedContracts; }
        public static string[,] SearchOptions { get => searchOptions ; }
        public static string[,] DeleteOptions { get => deleteOptions;}
        public static string[,] EditOptions { get => editOptions; }

        public static void RecieveWorldInfo()
        {
            string json = File.ReadAllText("countries.json");
            Countries = JsonSerializer.Deserialize<Country[]>(json: json);
            json = File.ReadAllText("FAQ.json"); ;
            FAQ = JsonSerializer.Deserialize<string[]>(json);
        }

        public static void Claim(string contractNumber)
        {
            claimedContracts.Add(contractNumber);
        }

        public static void ClearClaimed()
        {
            claimedContracts.Clear();
        }
    }
}
