using TaxiPizzaApp;

namespace Home_Task_21_Worker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our developers are ready to make an order");

            var personPizza = new Person("Vasia");
            var taskPizza = personPizza.OrderPizza(TimeSpan.FromMinutes(0.25), true);

            var personTaxi = new Person("Petya");
            var taskTaxi = personTaxi.OrderTaxi(TimeSpan.FromMinutes(0.2), false);

            Task.WaitAll(taskPizza, taskTaxi);

            Console.WriteLine("Our developers got all their orders");           
        }
    }
}