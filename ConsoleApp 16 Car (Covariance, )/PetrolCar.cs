
namespace ConsoleApp_16_Car
{
   class PetrolCar: Car, ICarType<PetrolCar>
    {
        public PetrolCar(string name) : base(name, FuelType.Petrol)
        {
        }

        public string GetType()
        {
            return typeof(PetrolCar).ToString();
        }

    }
}
