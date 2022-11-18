
namespace ConsoleApp_16_Car
{
    public interface ICarInfo<in T> : ICar
    {
         FuelType GetFuelType();
    }
}
