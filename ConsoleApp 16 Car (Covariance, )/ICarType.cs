
namespace ConsoleApp_16_Car
{
     public interface ICarType<out T> : ICar
    {
        string GetType();
    }
}
