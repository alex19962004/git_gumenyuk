
namespace ConsoleApp_11__2_
{
     public class SportCar : Vehicle
    {
        
        public static string CarType = "SportCar";
        public static string Engine = "TurboJet";
        public int carSpeed;      
        public SportCar(string brand, int id, int maxCarSpeed, int acceleration, int distance) : base(brand, id, maxCarSpeed, acceleration, distance)
        {
        }
        public override void Go()
        {
            carSpeed = Acceleration * GameTime;           
            if (carSpeed > MaxCarSpeed)
            {
                carSpeed = MaxCarSpeed;
            }
            CurrentDistance += carSpeed;
            GameTime++;            
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
}
