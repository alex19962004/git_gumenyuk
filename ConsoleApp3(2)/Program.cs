namespace ConsoleApp3_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c = ");
            //int c = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out int c);
            int D = b * b - 4 * a * c;
            double x1 = 0;
            double x2 = 0;
            if (D < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
            }
            else if (D == 0)
                x1 = x2 = (-b + Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("D = " + D);
            Console.Write("x1 = ");
            Console.WriteLine("{0:0.000}", x1);
            Console.Write("x2 = ");
            Console.WriteLine("{0:0.000}", x2);
        }
    }
}