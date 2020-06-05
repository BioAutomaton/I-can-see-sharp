using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.ThreadsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage data = new Storage();

            data.StartSort();

            Console.Read();
        }
    }
}
