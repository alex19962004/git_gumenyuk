namespace ConsoleApp_11__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameTime;
            int distance = 1000;
            int maxTravelTime = 30;
            int amountOfCars = 3;
            int[,] result = new int[maxTravelTime, amountOfCars];

            Vehicle car1 = new SportCar("Ford", 1, 47, 6, distance);
            Vehicle car2 = new SportCar("Honda", 2, 51, 5, distance);
            Vehicle car3 = new SportCar("Mazda", 3, 55, 4, distance);
            var cars = new Vehicle[] { car1, car2, car3 };
            
            string[,] vehicleList = new string[4, 3];

            for (int i = 0; i < vehicleList.GetLength(0); i++)
            {
                for (int j = 0; j < vehicleList.GetLength(1); j++)
                {
                    vehicleList[0, j] = SportCar.CarType;
                    vehicleList[1, j] = SportCar.Engine;
                    vehicleList[2, j] = cars[j].Brand;
                    vehicleList[3, j] = cars[j].Id.ToString();                  
                    Console.Write("{0,-8}", vehicleList[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Game game = new Game();            
            game.Start();
            Console.WriteLine();
            for (gameTime = 0; gameTime < result.GetLength(0); gameTime++)
            {
                var carsOnTheSameDistance = new List<int>[distance];
                for (var i = 0; i < distance; i++)
                    carsOnTheSameDistance[i] = new List<int>();

                for (var carIndex = 0; carIndex < cars.Length; carIndex++)
                {
                    var currentCar = cars[carIndex];
                    if (currentCar.IsFinsihed())
                    {
                        continue;
                    }

                    currentCar.Go();
                    Console.WriteLine(currentCar.Id + " on the distance " + currentCar.CurrentDistance);


                    if (currentCar.IsStarting(gameTime))
                    {
                        Console.WriteLine(currentCar.Id + " starting on the distance " + currentCar.CurrentDistance);
                        continue;
                    }

                    if (currentCar.IsFinsihed())
                    {
                        Console.WriteLine("car Id " + currentCar.Id + " is finished ");
                        continue;
                    }
         
                    Random rand = new Random();
                    int randomObstacle = rand.Next(6);
                    if (carIndex == randomObstacle)
                    {
                        currentCar.Encounter();
                        Console.WriteLine(currentCar.Id + " encounter with obstacle, returned on the distance " + currentCar.CurrentDistance);
                    }

                    if (currentCar.CurrentDistance <= 0) continue;

                    carsOnTheSameDistance[currentCar.CurrentDistance].Add(currentCar.Id);
                    var carsOnThesameRowDistance = carsOnTheSameDistance[currentCar.CurrentDistance];

                    if (carsOnThesameRowDistance.Count > 1)
                    {
                        currentCar.Encounter();
                        Console.WriteLine("car Id " + currentCar.Id + " encounter with car Id " 
                            + carsOnThesameRowDistance[carsOnThesameRowDistance.Count-2] + ", returned on the distance " + currentCar.CurrentDistance);
                    }
                }
               
                Console.WriteLine();
            }    
            game.Finish();        
        }   
    }
}