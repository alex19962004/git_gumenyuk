
namespace ConsoleApp_16_Car
{
    public class ElectricCar: Car, ICarType<ElectricCar>
    {
        public ElectricCar(string name) : base(name, FuelType.Electric)
        {
        }
       
         public string GetType()
         {
             return typeof(ElectricCar).ToString();           
         }
    }
}
