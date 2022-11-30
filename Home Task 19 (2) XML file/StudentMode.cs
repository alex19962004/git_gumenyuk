
namespace XmlReader
{
    [Serializable]
    public class StudentModel
    {
        public StudentModel()
        {
        }
        public StudentModel(int id, string name, string surname, string university)
        {
            Id = id;
            Name = name;
            Surname = surname;
            University = university;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string University { get; set; }

        public override string ToString()
        {
            return $"The student with Id: {Id} and Name & Surname: {Name}, {Surname} from Univer: {University}";
        }
    }
}
