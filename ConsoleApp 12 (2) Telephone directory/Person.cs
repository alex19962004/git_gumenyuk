
namespace ConsoleApp_12__2_
{
    public enum NumberType : int { mobileNumber = 1, workNumber, officialNumber };
    public struct Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string WorkNumber { get; set; }
        public string OfficialNumber { get; set; }

        public Person(string surname, string name, string mobileNumber, string workNumber, string officialNumber)
        {
            Surname = surname;
            Name = name;
            MobileNumber = mobileNumber;
            WorkNumber = workNumber;
            OfficialNumber = officialNumber;
        }       
    }
}
