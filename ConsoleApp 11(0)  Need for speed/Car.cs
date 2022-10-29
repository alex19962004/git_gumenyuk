namespace ConsoleApp_11_1___Need_for_speed
{
    
    public abstract class Car
    {
        public static string CarType;
        public static string Engine;
        public int Acceleration { get; set; }
        public int RemainDistance { get; set; }       
        public int GameTime { get; set; }
        
        public int MaxCarSpeed { get; set; }

        public Car( int maxCarSpeed, int gameTime, int remainDistance, int acceleration)
        {
            MaxCarSpeed = maxCarSpeed;
            GameTime = gameTime;
            RemainDistance = remainDistance;
            Acceleration = acceleration;
        }

        public abstract int GetTraveledDistance();
    }
}
