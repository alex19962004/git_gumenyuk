
namespace ConsoleApp_16_Car
{
    class DieselCar: Car, ICarType<DieselCar>
    {
        public DieselCar(string name) : base(name, FuelType.Diesel)
        {
        }

        public string GetType()
        {
            return typeof(DieselCar).ToString();
        }
    }
}
