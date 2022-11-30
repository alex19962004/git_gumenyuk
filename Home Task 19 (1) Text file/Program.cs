using FileReader;

namespace ConsoleApp_19__1___Text_file
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            var inputFile = "C:/Users/User/source/repos/Home Task 19 (1) Text file/DataFile.txt";
            //var inputFile = "C:/Users/User/source/repos/text doc.txt";
            
            var outputFile = "C:/Users/User/source/repos/Home Task 19 (1) Text file/OutputFile.txt";
            //var outputFile = "C:/Users/User/source/repos/text doc.txt";

            var service = new Service();
            var wordCounters = service.GetWordCounters(inputFile);
            Console.WriteLine("Read and Calculated number words ...");                       
            Console.WriteLine();
            
            service.Save(wordCounters, outputFile);
            Console.WriteLine($"Saved to {outputFile}");
            Console.WriteLine();

            Console.WriteLine("The number of each of the words in the text is as follows:");
            foreach (var word in wordCounters)
                Console.WriteLine(word);

            
           
        }
    }
}