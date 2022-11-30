using XmlReader;

namespace ConsoleApp_19__2__XML_file
{
    internal class Program
    {
        static void Main(string[] args)
        {                   
            var students = new List<StudentModel>()
            {
                new StudentModel(1, "Name1", "Surname1", "Univer1"),
                new StudentModel(2, "Name2", "Surname2", "Univer2")
            };

            var file = "C:/Users/User/source/repos/Home Task 19 (2) XML file/Students.xml";
            //var file = "C:/Users/User/source/repos/XML doc.xml";
            
            var reader = new StudentXmlReader();
            reader.Save(file, students);

            Console.WriteLine($"Saved all students to {file}");
            Console.WriteLine();

            var studentsReadFromXml = reader.Read(file);           
            Console.WriteLine("All actual list of students:");
            if(studentsReadFromXml != null)
            {
                foreach (StudentModel student in studentsReadFromXml)                
                    Console.WriteLine(student.ToString());
            }                        
            Console.WriteLine();

            var newStudent = new StudentModel(3, "Name3", "Surname3", "Univer3");                     
            reader.AddStudent(file, newStudent);
            Console.WriteLine($"Add one more student: {newStudent}");                        
            Console.WriteLine();

            var studentsFinishedStateFile = reader.Read(file);            
            Console.WriteLine("New all actual list of students:");
            if( studentsFinishedStateFile != null)
            {
                foreach (StudentModel student in studentsFinishedStateFile)           
                    Console.WriteLine(student.ToString());
            }                          
        }
    }
}