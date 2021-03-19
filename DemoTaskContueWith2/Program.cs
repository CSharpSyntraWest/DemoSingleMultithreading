using System;
using System.Threading.Tasks;

namespace DemoTaskContueWith2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoofd-thread is opgestart");
            Task<int> task = Task.Run(() =>
            {
                return 10;
            });
            task.ContinueWith((result) =>
            {
                Console.WriteLine("Taak is geannuleerd");
            }, TaskContinuationOptions.OnlyOnCanceled);

            task.ContinueWith((result) =>
            {
                Console.WriteLine("Taak geeft fout");
            }, TaskContinuationOptions.OnlyOnFaulted);

             var completedTask = task.ContinueWith(
             (result) =>
             {
                 Console.WriteLine($"kwadraat van {result.Result} is {result.Result * result.Result}");
             }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();//hoofd-thread wacht dan totdat completedTask is beëindigd
            //task.ContinueWith((result) =>
            //{
            //    Console.WriteLine($"kwadraat van {result.Result} is {result.Result * result.Result}");
            //});
            Console.WriteLine("Hoofd-thread is beëindigd");
            Console.ReadKey();
        }
    }
}
