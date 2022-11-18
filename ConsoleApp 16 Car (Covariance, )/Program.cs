namespace ConsoleApp_16_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example covar
            //ex1
            ICarType<PetrolCar> petrolCar1 = new PetrolCar("Toyota");
            ICarType<ICar> carTypePetrol = petrolCar1;
            var result1 = carTypePetrol.Refuel(FuelType.Petrol);
            Console.WriteLine(result1);

            //ex2
            ICarType<ICar> petrolCar2 = new PetrolCar("Ford");
            var result2 = petrolCar2.Refuel(FuelType.Petrol);
            Console.WriteLine(result2);

            // ex3
            ICarType<ICar> electricCar1 = new ElectricCar("Nissan");
            var result3 = electricCar1.Refuel(FuelType.Electric);
            Console.WriteLine(result3);

            //example cont
            ICarInfo<DieselCar> dieselCar = new Car("Opel", FuelType.Diesel);
            var result4 = dieselCar.Refuel(FuelType.Diesel);
            Console.WriteLine(result4);          
        }
    }
}
