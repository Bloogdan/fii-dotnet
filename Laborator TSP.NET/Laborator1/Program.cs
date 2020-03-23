using System;
using System.Collections.Generic;
using System.Threading;

namespace NumerePrime
{
    class Program
    {
        static object messagelock = new object();
        static int number;
        static List<string> Messages;
        static void Main(string[] args)
        {
            Messages = new List<string>();
            Console.WriteLine("Find biggest prime smaller than: ");
            number = Convert.ToInt32(Console.ReadLine());

            Thread t1 = new Thread(new ThreadStart(ThreadProc));
            Thread t2 = new Thread(new ThreadStart(ThreadProc));

            t1.Name = "Thread1";
            t2.Name = "Thread2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            foreach (string s in Messages)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        static void ThreadProc()
        {
            lock (messagelock)
                Messages.Add("Start Fir: " + Thread.CurrentThread.Name + " " + DateTime.Now.ToString("h:mm:ss tt") + ", Numarul Dat: " + number);

            int result;

            if (Thread.CurrentThread.Name == "Thread1") result = BiggestPrimeSmallerThanMethod1(number);
            else result = BiggestPrimeSmallerThanMethod2(number);


            lock (messagelock)
                Messages.Add("End Fir: " + Thread.CurrentThread.Name + " " + DateTime.Now.ToString("h:mm:ss tt") + ", Numar Prim: " + result);
        }

        static int BiggestPrimeSmallerThanMethod1(int n)
        {
            //Cautare iterativa
            for (int i = n - 1; i >= 2; i--)
            {
                if (i == 2) return i;
                if (i % 2 == 0) continue;
                for (int j = 3; j * j <= i; j += 2)
                {
                    if (i % j == 0) continue;
                }
                return i;
            }
            return -1;
        }

        static int BiggestPrimeSmallerThanMethod2(int n)
        {
            //Ciurul lui Eratostene
            int[] ciur = new int[n];
            ciur[0] = 1;
            ciur[1] = 1;

            for (int i = 2; i < n; i++)
            {
                if (ciur[i] == 0)
                {
                    int j = i * 2;
                    while (j < n)
                    {
                        ciur[j] = 1;
                        j += i;
                    }
                }
            }

            for (int i = n - 1; i >= 2; i--)
            {
                if (ciur[i] == 0) return i;
            }
            return -1;
        }
    }

}
