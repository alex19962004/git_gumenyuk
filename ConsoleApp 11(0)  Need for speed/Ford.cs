
namespace ConsoleApp_11_1___Need_for_speed
{
    public class Ford : Car
    {
        //public static int Distance;
        //public int RemainDistance;
        public int CarSpeed;
        public Ford(int maxCarSpeed, int gameTime, int remainDistance, int acceleration) : base(maxCarSpeed, gameTime, remainDistance, acceleration)
        {
            MaxCarSpeed = maxCarSpeed;
            GameTime = gameTime;
            RemainDistance = remainDistance;
            Acceleration = acceleration;
        }      
        public override int GetTraveledDistance()
        {

            for( int i = GameTime; i <= GameTime; i++)
            {
                CarSpeed = (i * Acceleration);
                if (CarSpeed >= MaxCarSpeed)
                {
                    CarSpeed = MaxCarSpeed;
                }
                RemainDistance -=  CarSpeed * i;
                if (RemainDistance <= 0)
                {
                    return 0;
                }
            }
            return RemainDistance;
        }
    }
}
