
namespace ConsoleApp_13__2__Exception_CustomException
{
     class CustomException: Exception
    {
        public CustomException(string message) : base(message)
        {
           Console.WriteLine(message);
        }
    }
}
