using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_11_1___Need_for_speed
{
    public class Game
    {
        public void Start(int distance)
        {
            var cars = GetCars();
            var distanceTrack = new List<CarGame>[distance];
            //Car1, SpeedPerSec - 5
            // Car2, SpeedPerSec - 3
            // Car3, SpeedPerSec - 3

            // 1 sec
            // Car1 -> Move() -> currentDistance = 0 + SpeedPerSec => 0 + 5 => 5 - CurrentPostion
            // Car2 -> Move() -> curentDistamcee = 0 + SpeedPerSEc => 0 + 3 => 3 - CurrentPostion
            // Car3 -> Move() -> currentDistance = 0 + SpeedPerSec => 0 + 3 => 3 - CurrentPostion

            // [0], 
            // [1],
            // [2],
            // [3], Car2, Car3
            // [4],
            // [5], Car1

            int time = 0;

            while (time <= 25)
            {
                foreach(var car in cars)
                {
                    car.Move();
                    distanceTrack[car.CurrentPosition].Add(car);
                    var carsOnTheSameDistance = distanceTrack[car.CurrentPosition];
                    if (carsOnTheSameDistance.Count > 1)
                    {

                    }

                    //if (car.CurrentPosition >= distance)

                }

                time++;
            }
        }

        public CarGame[] GetCars()
        {
            return new CarGame[0];
        }
    }

    public abstract class CarGame
    {
        public int Id { get; }
        public string Name { get; }
        public int SpeedPerSec { get; }
        public int CurrentPosition { get; set; }

        public CarGame(int id, string name, int speedPerSec)
        {
            Id = id;
            Name = name;
            SpeedPerSec = speedPerSec;
        }

        public abstract void Move();
    }

    public class FordGame : CarGame
    {
        public FordGame(int id, string name, int speedPerSec) 
            : base(id, name, speedPerSec)
        {
        }

        public override void Move()
        {
            CurrentPosition += SpeedPerSec;
        }
    }
}
