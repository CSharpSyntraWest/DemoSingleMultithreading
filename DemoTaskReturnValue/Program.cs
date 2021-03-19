using System;
using System.Threading.Tasks;

namespace DemoTaskReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoofd-thread opgestart");
            Task<int> task1 = Task.Run(() =>
            {
                return BerekenSom(10);
            });
            Console.WriteLine("De som van de eerste 10 getallen is: " + task1.Result);
            Console.WriteLine("Hoofd-thread beëindigd");
            Console.ReadKey();
        }

        private static int BerekenSom(int getal)
        {
            int som = 0;
            for (int teller = 1; teller <= getal; teller++)
            {
                som += teller;  
            }
            return som;
        }
    }
}
