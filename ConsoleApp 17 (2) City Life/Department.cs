
namespace ConsoleApp_17__2__City_Life
{
    public enum DepartmentType
    {
        Police,
        FireStation,
        Ambulance
    }

    public abstract class Department
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public Department(string id, string description, string address)
        {
            Id = id;
            Description = description;
            Address = address;
        }

        public abstract void Call();

        protected string GetDefaultMessage()
        {
            return $"got your request № {Id}, with description: {Description}, address: {Address}";
        }
    }
}
