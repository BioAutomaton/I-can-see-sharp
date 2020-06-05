using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6.Threads
{
    class Storage
    {
        const int size = 10;
        int[] first = new int[size];
        int[] second = new int[size];

        Thread firstThread;
        Thread secondThread;

        public Thread FirstThread { get => firstThread; }
        public Thread SecondThread { get => secondThread; }

        public Storage()
        {
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                first[i] = r.Next(0, 25);
                second[i] = r.Next(0, 25);
            }
            firstThread = new Thread(SortFirst);
            secondThread = new Thread(SortSecond);
        }


        public void SortFirst()
        {
            int temp;
            for (int j = 0; j <= first.Length - 2; j++)
            {
                for (int i = 0; i <= first.Length - 2; i++)
                {
                    if (first[i] > first[i + 1])
                    {
                        temp = first[i + 1];
                        first[i + 1] = first[i];
                        first[i] = temp;
                    }
                    Thread.Sleep(50);
                }
            }
            FirstThread.Abort();
        }

        public string DisplayFirst()
        {
            string temp = "";
            foreach (int item in first)
            {
                temp += item.ToString() + " ";
            }
            temp += "\n";
            return temp;
        }

        public void SortSecond()
        {
            int temp;
            for (int j = 0; j <= second.Length - 2; j++)
            {
                for (int i = 0; i <= second.Length - 2; i++)
                {
                    if (second[i] < second[i + 1])
                    {
                        temp = second[i + 1];
                        second[i + 1] = second[i];
                        second[i] = temp;
                    }
                    Thread.Sleep(50);
                }
            }
            SecondThread.Abort();
        }

        public string DisplaySecond()
        {
            string temp = "";
            foreach (int item in second)
            {
                temp += item.ToString() + " ";
            }
            temp += "\n";
            return temp;
        }
    }
}
