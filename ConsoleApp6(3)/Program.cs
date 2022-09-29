namespace ConsoleApp6_3_
{
    internal class Program
    {
       static ulong Factorial(ulong n)
        {
            if (n == 1)
                return 1;
         
            else
                return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number ");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong result = Factorial(n);    
            Console.WriteLine("Factorial of a number is " + result);
        }
    }
}