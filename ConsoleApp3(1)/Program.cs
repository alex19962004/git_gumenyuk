namespace ConsoleApp3_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text...");
            string text = Console.ReadLine();
            string textLower = text.ToLower();
            char[] textChar = textLower.ToCharArray();
            int numberA = 0;
            int numberB = 0;
            int numberC = 0;
            int numberD = 0;
            for (int i = 0; i < textChar.Length; i++)
            {
                if (textChar[i] == 'a')
                    numberA++;
                else if (textChar[i] == 'b')
                    numberB++;
                else if (textChar[i] == 'c')
                    numberC++;
                else if (textChar[i] == 'd')
                    numberD++;
                else
                    continue;
            }
            Console.WriteLine("Number of letters A in the text = " + numberA);
            Console.WriteLine("Number of letters B in the text = " + numberB);
            Console.WriteLine("Number of letters C in the text = " + numberC);
            Console.WriteLine("Number of letters D in the text = " + numberD);
        }
    }
}