using System;

namespace BabySteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
        label:
            i++;
            j += i;
            if (i<10)
            {
                Console.Write(i + " ");
                goto label;

            }
            Console.ReadLine();
        }

        
    }
}
