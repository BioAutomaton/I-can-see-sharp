using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.InterfacesConsole
{
    class Program
    {
        static List<Person> data = new List<Person>();
        static int GetChoice(int rangeLower, int rangeUpper)
        {
            int selection;
            bool isCorrect;
            do
            {
                Console.Write("Your Choice: ");
                isCorrect = Int32.TryParse(Console.ReadLine(), out selection);
                if (selection < rangeLower || selection > rangeUpper)
                {
                    isCorrect = false;
                }

                if (!isCorrect)
                {
                    Console.WriteLine("Wrong entering");
                }
            } while (!isCorrect);

            return selection;
        }

        static int SelectFromList(string message)
        {
            Console.WriteLine($"{message} (1 - { data.Count})");
            int selection = GetChoice(1, data.Count);
            return selection;
        }
        static void Add()
        {

            Console.WriteLine("Choose who you want to add to the list:\n1 - Servant\n2 - Worker\n3 - Engineer\n4 - Just a person");

            int selection = GetChoice(1, 4);

            switch (selection)
            {
                case 1:
                    data.Add(new Servant());
                    break;
                case 2:
                    data.Add(new Worker());
                    break;
                case 3:
                    data.Add(new Engineer());
                    break;
                case 4:
                    data.Add(new Person());
                    break;
                default:
                    Console.WriteLine("An error occurred.");
                    break;
            }


        }
        static private void Delete()
        {
            data.RemoveAt(SelectFromList("Choose a person to delete") - 1);
        }

        static private void DisplayAll()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static private void RaiseSalary()
        {
            int index = SelectFromList("Choose person to increase salary")-1;
            ushort entering;
            bool isCorrect;
            do
            {
                Console.Write("Enter amount: ");
                isCorrect = UInt16.TryParse(Console.ReadLine(), out entering);
                if (entering < 0)
                {
                    isCorrect = false;
                }

                if (!isCorrect)
                {
                    Console.WriteLine("Wrong entering");
                }
            } while (!isCorrect);
            data[index].Raise(entering);
        }

        static private void Retire()
        {
            int index = SelectFromList("Choose person to retire") - 1;
            data[index].Retire();
        }
        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine("Choose an action.");
                Console.WriteLine("1 - Add person to the list");
                Console.WriteLine("2 - Delete person from the list");
                Console.WriteLine("3 - Display all list");
                Console.WriteLine("4 - Raise salary");
                Console.WriteLine("5 - Retire");

                Console.WriteLine("0 - Exit");
                selection = GetChoice(0, 5);

                switch (selection)
                {
                    case 0:
                        break;
                    case 1:
                        Add();
                        break;
                    case 2:
                        Delete();
                        break;
                    case 3:
                        DisplayAll();
                        break;
                    case 4:
                        RaiseSalary();
                        break;
                    default:
                        Console.WriteLine("An error occurred.");
                        break;
                }
            } while (selection != 0);


            Console.ReadLine();
        }

    }
}
