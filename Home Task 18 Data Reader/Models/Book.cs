
namespace DataReader.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Book(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public override string ToString()
        {
            return $"The book with Id: {Id} and Title: {Title}";
        }
    }
}
