using System;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread opgestart: { Thread.CurrentThread.ManagedThreadId}");
            // Task task1 = new Task(PrintTeller);
            // task1.Start();
            Task task1 = Task.Run(()=> { PrintTeller(); });
            //task1.Wait();//Met Wait() methode kan je de Main thread laten wachten totdat deze kind thread is beëindigd.
            Console.WriteLine($"Main Thread beëindigd: { Thread.CurrentThread.ManagedThreadId}");
            Console.ReadKey();
        }

        private static void PrintTeller()
        {
            Console.WriteLine($"Kind Thread opgestart: { Thread.CurrentThread.ManagedThreadId}");
            for (int teller = 1; teller <= 5; teller++)
            {
                Console.WriteLine($"Teller is {teller}");
            }
            Console.WriteLine($"Kind Thread beëindigd: { Thread.CurrentThread.ManagedThreadId}");

        }
    }
}
