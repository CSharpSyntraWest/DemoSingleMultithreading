using System;
using System.Threading.Tasks;

namespace DemoTaskContinueWith
{
    class Program
    {
        //Demo Chaining van Tasks dmv ContinueWith
        static void Main(string[] args)
        {
            Task<string> task1 = Task.Run(()=>
            {
                return 12;
            }).ContinueWith( (result)=>
                 {
                     return "Kwadraat van " + result.Result + " is : " + result.Result * result.Result;
                 }            
            );
            Console.WriteLine(task1.Result);
            Console.ReadKey();
        }
    }
}
