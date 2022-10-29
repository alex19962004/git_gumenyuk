
namespace ConsoleApp_11__2_
{
     class Game
    {       
        public void Go(Vehicle vehicle)
        {
            vehicle.Go();
        }
        public void Start()
        {
            Console.WriteLine(" S T A R T !!!");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i + "... ");
            }
            Console.WriteLine("Go!!!");
        }
        public void Finish()
        {
            Console.WriteLine(" F i N I S H !!!");
        }

    }
}
