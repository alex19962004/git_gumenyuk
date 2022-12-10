using DataReader.Models;
using System.Data.SqlClient;

namespace DataReader
{
    public class StudentRepository
    {
        private static string SQLConnectionString =
            "Data Source = MSSQL1; Initial Catalog = testdb; User ID = root; Password=test";

        public Student GetStudent(int studentId)
        {
            using var conn = new SqlConnection(SQLConnectionString);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Students WHERE Id = @StudentId";
            cmd.Parameters.Add("@StudentId", System.Data.SqlDbType.Int).Value = studentId;

            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return new Student((int)reader[0], (string)reader[1], (string)reader[2]);
            }
            return null;
        }

        public List<Book> GetBooks(int studentId)
        {
            var result = new List<Book>();

            using var conn = new SqlConnection(SQLConnectionString);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Books WHERE StudentId = @StudentId";
            cmd.Parameters.Add("@StudentId", System.Data.SqlDbType.Int).Value = studentId;

            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var currentBook = new Book((int)reader[0], (string)reader[1]);
                result.Add(currentBook);
            }
            return result;
        }

        public List<Lesson> GetLessons(int studentId)
        {
            var result = new List<Lesson>();

            using var conn = new SqlConnection(SQLConnectionString);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Lessons INNER JOIN StudentToLesson ON Lessons.Id=StudentToLesson.LessonId WHERE StudentId = @StudentId";
            cmd.Parameters.Add("@StudentId", System.Data.SqlDbType.Int).Value = studentId;

            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var currentBook = new Lesson((int)reader[0], (string)reader[1]);
                result.Add(currentBook);
            }
            return result;
        }
    }
}
