using System.Text;

namespace FileReader
{
    public class FileReader
    { 
        public List<string> Read(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException($"The {fileName} was not found.");

            var str = File.ReadAllText(fileName, Encoding.UTF8);
            var charsToRemove = new List<char> { '@', '_', ',', '.', ' ', '!', '\n', '\r' };
            var words = str
                .Split(charsToRemove.ToArray())
                .Where(s => s != "")
                .Select(s => s.ToLower()).ToList();

            return words.ToList();
        }
        public void Save(List<WordCounter> wordCounters, string file)
        {
            if (File.Exists(file))
                File.Delete(file);

            using StreamWriter writer = new StreamWriter(file);
            foreach (var wordCounter in wordCounters)
                writer.WriteLine($"{wordCounter.Word} - {wordCounter.Count}");
        }

       
    }
}
