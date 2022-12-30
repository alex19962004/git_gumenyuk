using CivilizationGame.Models;

namespace CivilizationGame
{
    internal class Program
    {
        static async Task Main(string[] args)
        {   
            string choice1;
            string choice2;
            int id;
            int population;
            int maxPopulation;
            int from;
            int to;
            
            DevelopmentPower developmentPower;
            var god = new God();
            Console.WriteLine("If you want to destroy all the people of the civilization, press D and id of the civilization!!!");
            Console.WriteLine("If you want to provoke an epidemic in a civilization, press R and id of the civilization!!!");
            Console.WriteLine();
            Console.WriteLine("Do you want to enter the characteristics of civilization???");
            Console.WriteLine(" - YES      - press + ");
            Console.WriteLine(" - NO       - press = ");
            choice1 = Console.ReadLine();

            void CreateCivilization()
            {
                while (true)
                {
                    try
                    {
                        id = int.Parse(choice2);
                        Console.Write("Enter the desired initial number of civilization people ...");
                        population = int.Parse(Console.ReadLine());
                        Console.Write("Enter the desired maximum number of civilization people ...");
                        maxPopulation = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the desired number of invention category in civilization from 1 to 5 ...");
                        Console.Write("from ...");
                        from = int.Parse(Console.ReadLine());
                        Console.Write("to ...");
                        to = int.Parse(Console.ReadLine());
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Wrong input!!!");
                        continue;
                    }
                    break;
                }                
            }
           
            while (choice1 == "+")
            {
                Console.WriteLine("... for Tyranid Civilization    - press 1");
                Console.WriteLine("... for Ork Civilization        - press 2");
                Console.WriteLine("... for Eldar Civilization      - press 3");
                Console.WriteLine("... for Necrons Civilization    - press 4");

                choice2 = Console.ReadLine();
                switch (choice2)
                {
                    case "1":                   
                        CreateCivilization();
                        var tyranidCivilization = new TyranidCivilization(
                        id,
                        population,
                        maxPopulation,
                        new DevelopmentPower(from, to),
                        new Dictionary<InventionCategory, Invention>());                   
                        god.AddCivilization(tyranidCivilization);
                        break;
                    case "2":                    
                        CreateCivilization();
                        var orkCivilization = new OrkCivilization(
                        id,
                        population,
                        maxPopulation,
                        new DevelopmentPower(from, to),
                        new Dictionary<InventionCategory, Invention>());
                        god.AddCivilization(orkCivilization);
                        break;
                    case "3":
                        CreateCivilization();
                        var eldarCivilization = new EldarCivilization(
                        id,
                        population,
                        maxPopulation,
                        new DevelopmentPower(from, to),
                        new Dictionary<InventionCategory, Invention>());
                        god.AddCivilization(eldarCivilization);
                        break;
                    case "4":
                        CreateCivilization();
                        var necronsCivilization = new NecronsCivilization(
                        id,
                        population,
                        maxPopulation,
                        new DevelopmentPower(from, to),
                        new Dictionary<InventionCategory, Invention>());
                        god.AddCivilization(necronsCivilization);
                        break;
                    default:
                        Console.WriteLine("Wrong input!!!");
                        break;
                }                
                Console.WriteLine("Continue enter the characteristics     - press + ");
                Console.WriteLine("Enough                                 - press = ");
                choice1 = Console.ReadLine();
            }


            if (choice1 == "=")                                        
            {
             var tyranidCivilization = new TyranidCivilization(
                   1,
                   1000,
                   1000000,
                   new DevelopmentPower(1, 5),
                   new Dictionary<InventionCategory, Invention>()); 

               var orkCivilization = new OrkCivilization(
                   2,
                   9000,
                   1000000,
                   new DevelopmentPower(1, 5),
                   new Dictionary<InventionCategory, Invention>());

               var eldarCivilization = new EldarCivilization(
                   3,
                   5000,
                   1000000,
                   new DevelopmentPower(1, 5),
                   new Dictionary<InventionCategory, Invention>());

               var necronsCivilization = new NecronsCivilization(
                   4,
                   8000,
                   1000000,
                   new DevelopmentPower(1, 5),
                   new Dictionary<InventionCategory, Invention>());
              //  var god = new God();
                god.AddCivilization(tyranidCivilization);
                god.AddCivilization(orkCivilization);
                god.AddCivilization(eldarCivilization);
                god.AddCivilization(necronsCivilization);
            }

            Task consoleKeyTask = Task.Run(() => { MonitorKeypress(god); });
            await god.CreateWorld();
            
        }
        public static void MonitorKeypress(God god)
        {
            var consoleKeysDropCiviliazation = new List<ConsoleKey>() { ConsoleKey.D1, ConsoleKey.D2, ConsoleKey.D3 };

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            do
            {
                cki = Console.ReadKey(true);                             
            }
            while (cki.Key != ConsoleKey.D && cki.Key != ConsoleKey.R);    
            {
                var id = Console.ReadKey();

                if (cki.Key == ConsoleKey.D)
                    god.DropCivilization(id.KeyChar - '0');

                if (cki.Key == ConsoleKey.R)
                    god.RaiseEpidemic(id.KeyChar - '0');
            }
        }
    }
}