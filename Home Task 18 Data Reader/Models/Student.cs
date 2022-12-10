

namespace DataReader.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"The student with Id: {Id} and Name&Surname: {Name},{Surname}";
        }
    }
}
