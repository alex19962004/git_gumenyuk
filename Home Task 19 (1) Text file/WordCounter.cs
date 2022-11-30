
namespace FileReader
{
    public class WordCounter
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public WordCounter(string word, int count)
        {
            Word = word;
            Count = count;
        }
        public override string ToString()
        {
            return Word + " " + Count;
        }
    }
}
