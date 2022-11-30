
namespace FileReader
{
    public class Service
    {
        public List<WordCounter> GetWordCounters(string file)
        {
            var fileReader = new FileReader();
            var words = fileReader.Read(file);
            var dict = new Dictionary<string, int>();
          
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                    dict[word] += 1;
                else
                    dict.Add(word, 1);
            }

            var result = new List<WordCounter>();
            foreach (var item in dict)
                result.Add(new WordCounter(item.Key, item.Value));

            return result;
        }

        public void Save(List<WordCounter> wordCounters, string file)
        {
            var fileReader = new FileReader();
            fileReader.Save(wordCounters, file);
        }
    }
}
