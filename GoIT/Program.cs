using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoIT
{
    internal class Program
    {
        const int defaultStartIndexSum = -100;

        static void Main(string[] args)
        {
            /*string string1 = "This is a string created by assignment.";
            Console.WriteLine(string1);
            char[] chars = { 'w', 'o', 'r', 'd' };
            string string2 = new string(chars);
            Console.WriteLine(string2);
            string string3 = new string('c', 20);
            Console.WriteLine(string3);
            string string4 = "Today is " + DateTime.Now.ToString("D");
            Console.WriteLine(string4);
            string sentence = "This sentence has five words.";
            // Extract the second word.
            int startPosition = sentence.IndexOf(" ") + 1;
            string word2 = sentence.Substring(startPosition,
                                              sentence.IndexOf(" ", startPosition) - startPosition);
            Console.WriteLine("Second word: " + word2);*/




            /* int[] values = { 98, 4, 89 };
             int startValue = 4;
                 int startIndexSum = defaultStartIndexSum;
                 for (int i = 0; i < values.Length; i++)
                 {
                     if (values[i] == startValue)
                     startIndexSum = i;
                 }

             if (startIndexSum == defaultStartIndexSum)
             {
                 Console.WriteLine("Number is not exist in the array");
                 return;
             }

                 int sum = 0;
                 for (int j = startIndexSum + 1; j < values.Length; j++)
                 {
                     sum += values[j];
                     if (startIndexSum == values.Length)
                        Console.WriteLine (0);
                 }
                 Console.WriteLine(sum);
            /* int a = 4;
             Console.WriteLine(a);*/



            int[] ages = { 26, 30, 27 };
                    // write your code below this line
                    int highersAge = ages[0];
                    int lowestAge = ages[0];
                    int[] result = { highersAge, lowestAge };
                    // write your code above this line
                    for (int i = 0; i < ages.Length; i++)
                    {
                        if (ages[i] >= highersAge)
                            highersAge = ages[i];
                        else if (lowestAge <= ages[i])
                            lowestAge = ages[i];
                    }

            Console.WriteLine(result[1]);

                    Console.ReadLine();
        }
    }
}