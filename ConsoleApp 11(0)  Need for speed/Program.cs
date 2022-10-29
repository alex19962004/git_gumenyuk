namespace ConsoleApp_11_1___Need_for_speed
{
     class Program
    {
        static void Main(string[] args)
        {           
            Car.CarType = "SportCar";
            Car.Engine = "Turbo";
                      
            int maxCarSpeed;
            int gameTime;
            int remainDistance = 1000;
            int acceleration;            
            int maxTravelTime = 21;
            
            //Car car1 = new Ford(50, gameCurrentTime, 1000, 6);
            // Car car2 = new Honda(52, gameCurrentTime, 1000, 5);

            string[,] g = new string[2, 3];
            for(int i = 0; i < g.GetLength(0); i++)
            {
                for(int j = 0; j < g.GetLength(1); j++)
                {
                    g[0, j] = Car.CarType;
                    g[1, j] = Car.Engine;
                    //g[2, j] = Car.Brand;
                    //g[3, j] = Car.ID;
                    Console.Write(g[i, j]);
                }
                Console.WriteLine();
            }                

            int[,] result = new int[maxTravelTime, 3];

            for(gameTime = 9; gameTime < result.GetLength(0); gameTime++)
            {
                for(int j = 0; j < result.GetLength(1); j++)
                {
                    Car car1 = new Ford(50, gameTime, remainDistance, 6);              
                    Car car2 = new Honda(52,gameTime, remainDistance, 5);
                    Car car3 = new Ford(54, gameTime, remainDistance, 4);

                    result[gameTime,0] = car1.GetTraveledDistance();              
                    result[gameTime,1] = car2.GetTraveledDistance();
                    result[gameTime, 2] = car3.GetTraveledDistance();

                    Console.Write(result[gameTime, j] + " ");

                    if (result[gameTime,0] == result[gameTime,1] && result[gameTime,0] != 1000 && result[gameTime,0] !=0)
                    {
                        if (result[gameTime - 1, 0] < result[gameTime - 1, 1])
                        {                            
                            car1.RemainDistance += 30;

                        }
                        else car2.RemainDistance += 30;
                            
                    }                   
                }
                Console.WriteLine();
                
            }
        }
       
     }
}