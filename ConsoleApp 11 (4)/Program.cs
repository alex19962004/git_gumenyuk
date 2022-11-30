namespace ConsoleApp_11__4_
{
    class Game
    {
       /* public void Go(Vehicle vehicle)
        {
            vehicle.Go( gameTime);
        }*/
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
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Id { get; set; }
        public int Acceleration { get; set; }
        public int MaxCarSpeed { get; set; }
        public int CurrentDistance { get; set; }
        public int GameTime { get; set; }
        public int Distance { get; set; }
        public abstract int Go(int gametime);
        public abstract bool IsFinsihed();
        public abstract bool IsStarting(int gametime);

        public Vehicle(string brand, int id, int maxCarSpeed, int acceleration, int distance)
        {
            Brand = brand;
            Id = id;
            MaxCarSpeed = maxCarSpeed;
            Acceleration = acceleration;
            Distance = distance;
        }
        public abstract int Encounter();


    }
    public class SportCar : Vehicle
    {

        public static string CarType = "SportCar";
        public static string Engine = "TurboJet";
        public int carSpeed;
        
        public SportCar(string brand, int id, int maxCarSpeed, int acceleration, int distance) : base(brand, id, maxCarSpeed, acceleration, distance)
        {          
        }
        public override int Go(int gameTime)
        {
            carSpeed = Acceleration * gameTime;
            if (carSpeed > MaxCarSpeed)
            {
                carSpeed = MaxCarSpeed;
            }
            CurrentDistance += carSpeed;
            return CurrentDistance;
           // gameTime++;
        }
        public override int Encounter()
        {
            return CurrentDistance -= 5;
        }

        public override bool IsFinsihed()
        {
            return CurrentDistance >= Distance;
        }
        public override bool IsStarting(int gametime)
        {
            return gametime == 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int gameTime;
            int distance = 1000;
            int maxTravelTime = 26;
            int amountOfCars = 3;
            int currentDistance = 0;
            

            Vehicle car1 = new SportCar("Ford", 111, 51, 5, distance);
            Vehicle car2 = new SportCar("Honda", 222, 47, 6, distance);
            Vehicle car3 = new SportCar("Mazda", 333, 55, 6, distance);
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
                    Console.Write("{0,-10}", "|" + vehicleList[i, j] );
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Game game = new Game();
            game.Start();
            Console.WriteLine();

            int[,] result = new int[maxTravelTime, amountOfCars]; 
            
            int[] allCurrentDistance = new int[amountOfCars];
                   

            for (gameTime = 0; gameTime < maxTravelTime; gameTime++)
            {
                for (int j = 0; j < cars.Length; j++)
                {                   
                    currentDistance = cars[j].Go(gameTime); 
                    
                    allCurrentDistance[j] = currentDistance;
                   
                    if(j >= 1 && currentDistance != 0 && allCurrentDistance[j-1] == allCurrentDistance[j])
                    {
                        cars[j].Encounter();
                        Console.Write("(the car " + cars[j - 1].Id + " " + "and " + cars[j].Id + " " + "encountered, distance -5) ");                                              
                    }
                    if (j >= 2 && currentDistance != 0 && allCurrentDistance[j-2] == allCurrentDistance[2])
                    {
                        cars[j].Encounter();
                        Console.Write("(the car " + cars[j - 2].Id + " " + "and " + cars[j].Id + " " + "encountered, distance -5) ");
                    }
                        //int k = 1;
                    /*if (result[gameTime, j] != 0 && result[gameTime, j] == result[gameTime, j - 1] )
                        {
                            cars[j].Encounter();
                            Console.Write("(the car " + cars[j].Id + "and " + cars[j-1] + "encountered, distance -5) ");
                        }
                        if (result[gameTime, j] != 0 && result[gameTime, j] == result[gameTime, j - 2])
                        {
                            cars[j].Encounter();
                            Console.Write("(the car " + cars[j].Id + "and " + cars[j-2] + "encountered, distance -5) ");
                        }
                      if (j >= 1 && currentDistance != 0 && allCurrentDistance[1] == allCurrentDistance[2])
                    {
                        cars[j +2].Encounter();
                        Console.Write("(the car " + cars[j].Id + " " + "and " + cars[j +1].Id + " " + "encountered, distance -5) ");
                    }*/
                    /*if (j >= 1 && result[gameTime, j] != 0 && result[gameTime, j] == result[gameTime, j - 2])
                    {
                        cars[j].Encounter();
                        Console.Write("(the car " + cars[j].Id + "and " + cars[j - 2] + "encountered, distance -5) ");
                    }*/
                    Random rand = new Random();
                    int randomObstacle = rand.Next(0, 20);
                    if (j == randomObstacle)
                    {
                        cars[j].Encounter();
                           // currentDistance -= 50;

                        Console.Write("(the car " + cars[j].Id + " " + "encountered an obstacle, distance -5) ");
                            //  currentCar.Encounter();
                            //  Console.WriteLine(currentCar.Id + " encounter with obstacle, returned on the distance " + currentCar.CurrentDistance);
                    }
                   Console.Write("{0,-10}", currentDistance); 
                }

                /* var carsOnTheSameDistance = new List<int>[distance];
                 for (var i = 0; i < distance; i++)
                     carsOnTheSameDistance[i] = new List<int>();*/

                /*  for (var carIndex = 0; carIndex < cars.Length; carIndex++)
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
                              + carsOnThesameRowDistance[carsOnThesameRowDistance.Count - 2] + ", returned on the distance " + currentCar.CurrentDistance);
                      }
                  }*/

                Console.WriteLine();
            }
            game.Finish();
        }
    }
}