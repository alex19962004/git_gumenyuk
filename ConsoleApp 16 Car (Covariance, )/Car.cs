
namespace ConsoleApp_16_Car
{
    public enum FuelType
    {
        Diesel,
        Petrol,
        Electric
    }
    public class Car : ICarInfo<Car>
    {
        string Name;
        //string Type;
        FuelType FuelType;

        public Car(string name, FuelType fuelType)
        {
            Name = name;
            FuelType = fuelType;
        }
     
        public string GetName()
        {            
            return Name;
        }
        public bool Refuel(FuelType fuelType)
        {
             return FuelType == fuelType;
        } 
        
        public FuelType GetFuelType()
        {           
            return FuelType;
        }
    }
}
