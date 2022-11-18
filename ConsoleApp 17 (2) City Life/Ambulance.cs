
namespace ConsoleApp_17__2__City_Life
{
    public class Ambulance : Department
    {
        public Ambulance(string id, string description, string address) : base(id, description, address)
        {
        }

        public override void Call()
        {
            Console.WriteLine($"The {DepartmentType.Ambulance} {GetDefaultMessage()}");
        }
    }
}
