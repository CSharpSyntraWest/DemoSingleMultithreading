using System;
using System.Threading;

namespace DemoMultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread opgestart");
            //Aanmaken van 3 threads
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main thread eindigt");
            Console.ReadKey();
        }
        private static void Method1()
        {
            Console.WriteLine("Methode 1 opgestart door thread " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Methode 1: " + i);
            }
            Console.WriteLine("Methode 1 geëindigd door " + Thread.CurrentThread.Name);

        }
        private static void Method2()
        {
            Console.WriteLine("Methode 2 opgestart door thread " + Thread.CurrentThread.Name);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Methode 2: " + i);
                if (i == 3)
                {
                    Console.WriteLine("Methode 2 vraagt gegevens op uit database");
                    //Thread slaapt voor 10 seconden:
                    Thread.Sleep(10000);
                    Console.WriteLine("Methode 2 heeft gegevens uit db gekregen");
                }
            }
            Console.WriteLine("Methode 2 geëindigd door " + Thread.CurrentThread.Name);

        }
        private static void Method3()
        {
            Console.WriteLine("Methode 3 opgestart door thread " + Thread.CurrentThread.Name);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Methode 3: " + i);
            }
            Console.WriteLine("Methode 3 geëindigd door " + Thread.CurrentThread.Name);

        }




    }
}
