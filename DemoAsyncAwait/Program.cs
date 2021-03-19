using System;
using System.Threading.Tasks;

namespace DemoAsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string result = await Method1();
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static async Task<string> Method1()
        {
            string boodschap = "Mijn asynchrone methode 1 roept andere asynchrone methode Werkuren aan: ";
            var result = await WerkUren();
            return boodschap + result + " werkuren vandaag";
        }

        private static async Task<int> WerkUren()
        {
            DayOfWeek today = await Task.FromResult<DayOfWeek>(DateTime.Now.DayOfWeek);
            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                return 0;
            }
            else
            {
                return 8;
            }
        }
    }
}
