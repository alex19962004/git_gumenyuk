namespace ConsoleApp6_1__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the required action ");
            string action = Console.ReadLine();
            double result = 0;
            switch (action)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                        result = 0;
                    else
                        result = firstNumber / secondNumber;
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.WriteLine("Result is " + result);
        }
    }
}