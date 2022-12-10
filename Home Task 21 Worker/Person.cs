using System.Diagnostics;

namespace TaxiPizzaApp
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public async Task OrderTaxi(TimeSpan arrivalTime, bool beLate)
        {
            var freqToCheckWhereTheOrderIs = beLate == true ? 200 : 500;

            Console.WriteLine($"{Name} has ordered a taxi");

            var sp = new Stopwatch();
            sp.Start();

            while (sp.Elapsed <= arrivalTime)
            {
                Console.WriteLine($"{Name} is waiting for taxi");
                await Task.Delay(freqToCheckWhereTheOrderIs);
            }

            sp.Stop();

            Console.WriteLine($"{Name} got the pizza and waiting for {sp.Elapsed}");
        }

        public async Task OrderPizza(TimeSpan arrivalTime, bool beLate)
        {
            var freqToCheckWhereTheOrderIs = beLate == true ? 200 : 500;
            Console.WriteLine($"{Name} has ordered a Pizza");

            var sp = new Stopwatch();
            sp.Start();

            while (sp.Elapsed <= arrivalTime)
            {
                Console.WriteLine($"{Name} is waiting for Pizza");
                await Task.Delay(freqToCheckWhereTheOrderIs);
            }

            sp.Stop();

            Console.WriteLine($"{Name} got the pizza and waiting for {sp.Elapsed}");          
        }
    }
}
