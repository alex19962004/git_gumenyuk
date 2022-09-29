namespace ConsoleApp5_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] point = new int[2];
            Random random = new Random();
            int x = 0;
            int y = 0;
            double result = 0;

            for (int i = 0; i < point.Length; i++)
                point[i] = random.Next(-100,100);

            x = point[0];
            y = point[1];
            result = Math.Sqrt(x * x + y * y);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);


            if (result <= 10)
                Console.WriteLine("Your win is 10 points");
            else if (result > 10 && result <= 20)
                Console.WriteLine("Your win is 9 points");
            else if (result > 20 && result <= 30)
                Console.WriteLine("Your win is 8 points");
            else if (result > 30 && result <= 40)
                Console.WriteLine("Your win is 7 points");
            else if (result > 40 && result <= 50)
                Console.WriteLine("Your win is 6 points");
            else if (result > 50 && result <= 60)
                Console.WriteLine("Your win is 5 points");
            else if (result > 60 && result <= 70)
                Console.WriteLine("Your win is 4 points");
            else if (result > 70 && result <= 80)
                Console.WriteLine("Your win is 3 points");
            else if (result > 80 && result <= 90)
                Console.WriteLine("Your win is 2 points");
            else if (result > 90 && result <= 100)
                Console.WriteLine("Your win is 1 points");
            else
                Console.WriteLine("You are a loser");

        }
    }
}