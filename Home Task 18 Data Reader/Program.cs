

namespace DataReader
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studentRepository = new StudentRepository();

            var studentId = 1;

            var student = studentRepository.GetStudent(studentId);
            var books = studentRepository.GetBooks(studentId);
            var lessons = studentRepository.GetLessons(studentId);

            Console.WriteLine(student);
            Console.WriteLine("The student has these books:");
            foreach (var book in books)
                Console.WriteLine(book);

            Console.WriteLine("\nThe student has took lessons:");
            foreach (var lesson in lessons)
                Console.WriteLine(lesson);
        }
    }
}