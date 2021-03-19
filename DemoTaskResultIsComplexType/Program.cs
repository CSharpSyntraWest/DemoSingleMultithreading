using System;
using System.Threading.Tasks;

namespace DemoTaskResultIsComplexType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoofd-thread opgestart");
            Task<Persoon> task1 = Task.Run(() =>
            {
                Persoon persoon = new Persoon()
                {
                    Id = 1,
                    Naam = "Jos",
                    GeboorteDatum = new DateTime(1985, 10, 2)
                };
                return persoon;
            });
            Persoon persoonResult = task1.Result;
            Console.WriteLine($"Persoon Id: {persoonResult.Id} Naam: {persoonResult.Naam} " );
            Console.WriteLine("Hoofd-thread beëindigd");
            Console.ReadKey();
        }
    }
    public class Persoon
    { 
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
    }
}
