using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6.ThreadsConsole
{
    class Storage
    {
        const int size = 8;
        int[] first = new int[size];
        int[] second = new int[size];

        Thread firstDisplayThread;
        Thread secondDisplayThread;
        Thread firstThread;
        Thread secondThread;

        public Storage()
        {
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                first[i] = r.Next(0, 100);
                second[i] = r.Next(0, 100);
            }
        }
        public void StartSort()
        {
            firstThread = new Thread(SortFirst);
            secondThread = new Thread(SortSecond);

            firstDisplayThread = new Thread(DisplayFirst);
            secondDisplayThread = new Thread(DisplaySecond);

            firstDisplayThread.Start();
            firstThread.Start();

            secondDisplayThread.Start();
            secondThread.Start();
        }

        public void SortFirst()
        {
            int temp;
            for (int j = 0; j <= first.Length - 2; j++)
            {
                lock (this.first)
                {
                    for (int i = 0; i <= first.Length - 2; i++)
                    {
                        if (first[i] > first[i + 1])
                        {
                            temp = first[i + 1];
                            first[i + 1] = first[i];
                            first[i] = temp;
                            Thread.Sleep(500);
                        }
                    }
                }

            }
            firstThread.Abort();
        }

        public void SortSecond()
        {
            Thread.Sleep(50);
            int temp;
            for (int j = 0; j <= second.Length - 2; j++)
            {
                lock (this.second)
                {
                    for (int i = 0; i <= second.Length - 2; i++)
                    {
                        if (second[i] < second[i + 1])
                        {
                            temp = second[i + 1];
                            second[i + 1] = second[i];
                            second[i] = temp;
                            Thread.Sleep(500);
                        }
                    }
                }
            }
            secondThread.Abort();
        }

        public void DisplayFirst()
        {

            while (firstThread.ThreadState != ThreadState.Stopped)
            {
                lock (this.first)
                {
                    Console.Write("First: ");
                    foreach (int item in first)
                    {
                        Console.Write(item + " ");
                    }
                }
                Thread.Sleep(500);
                Console.Write("\n\n");
            }
            firstDisplayThread.Abort();
        }
        public void DisplaySecond()
        {
            Thread.Sleep(51);
            while (secondThread.ThreadState != ThreadState.Stopped)
            {
                lock (this.second)
                {
                    Console.Write("Second: ");
                    foreach (int item in second)
                    {
                        Console.Write(item + " ");
                    }
                }
                Thread.Sleep(500);
                Console.Write("\n\n");
            }
        }





    }
}
