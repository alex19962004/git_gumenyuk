
namespace ConsoleApp_11__2_
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Id { get; set; }
        public int Acceleration { get; set; }
        public int MaxCarSpeed { get; set; }
        public int CurrentDistance { get; set; }
        public int GameTime { get; set; }
        public int Distance { get; set; }
        public abstract void Go();
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
}
