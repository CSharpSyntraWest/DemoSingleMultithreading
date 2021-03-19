using System;
using System.Threading;

namespace DemoSingleMultithread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Culture: " + t.CurrentCulture.Name);
            Console.WriteLine("Thread Status: " + t.ThreadState.ToString());
            Console.WriteLine("Hello World!");
            Method1();
            Method2();
            Method3();
            Console.ReadKey();
        }

        private static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Methode 3: " + i);
            }
        }

        private static void Method2()
        {
           
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Methode 2: " + i);
                if (i == 3)
                {
                    Console.WriteLine("Methode 2 vraagt gegevens op uit database");
                    //Thread slaapt voor 5 seconden:
                    Thread.Sleep(10000);
                    Console.WriteLine("Methode 2 heeft gegevens uit db gekregen");
                }
            }
        }

        private static void Method1()
        {
            for (int i = 1;  i<= 5; i++)
            {
                Console.WriteLine("Methode 1: " + i);
            }
        }
    }
}
