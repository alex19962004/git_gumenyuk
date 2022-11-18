
namespace ConsoleApp_17__2__City_Life
{
    public class IncidentMessage
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DepartmentType DepartmentType { get; set; }

        public IncidentMessage(string id, string description, string address, DepartmentType departmentType)
        {
            Id = id;
            Description = description;
            Address = address;
            DepartmentType = departmentType;

        }
    }
}
