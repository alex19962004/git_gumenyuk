using System.Xml.Serialization;

namespace XmlReader
{
    public class StudentXmlReader
    {
        public List<StudentModel> Read(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The file with path {filePath} could not be found");

            XmlSerializer serializer = new XmlSerializer(typeof(List<StudentModel>));
            using var stream = File.OpenRead(filePath);
            var dezerializedList = (List<StudentModel>)serializer.Deserialize(stream);
            return dezerializedList;
        }

        public void Save(string file, List<StudentModel> studentModels)
        {
            if (File.Exists(file))
                File.Delete(file);

            var serialiser = new XmlSerializer(typeof(List<StudentModel>));

            TextWriter filestream = new StreamWriter(file);

            serialiser.Serialize(filestream, studentModels);
            filestream.Close();
        }

        public void AddStudent(string filePath, StudentModel student)
        {
            var students = Read(filePath);
            students.Add(student);

            Save(filePath, students);
        }
    }
}
