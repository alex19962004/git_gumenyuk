

namespace DataReader.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Lesson(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public override string ToString()
        {
            return $"The lesson with Id: {Id} and Description: {Description}";
        }
    }
}
