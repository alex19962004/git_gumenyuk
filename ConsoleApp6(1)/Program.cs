namespace ConsoleApp6_1_
{
     class NumberSystem
    {
        public int choice;
        public int firstNumber;
        public int secondNumber;
        public string action;
        public int result;

        public void Calculator()
        {
            if (choice == 1)
            {
                Console.WriteLine("Enter the first number ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the required action ");
                action = Console.ReadLine();
                {
                    if (action == "+")
                        result = firstNumber + secondNumber;
                    if (action == "-")
                        result = firstNumber - secondNumber;
                    if (action == "*")
                        result = firstNumber * secondNumber;
                    if (action == "/")
                        if (secondNumber == 0)
                            result = 0;
                        else
                            result = firstNumber / secondNumber;                   
                }
                Console.WriteLine("Result is " + result);
            }
            if (choice == 2)
            {
                Console.WriteLine("Enter the first number ");
                firstNumber = Convert.ToInt32(Console.ReadLine(), 2);
                Console.WriteLine("Enter the second number ");
                secondNumber = Convert.ToInt32(Console.ReadLine(), 2);
                Console.WriteLine("Enter the required action ");
                action = Console.ReadLine();
                {
                    if (action == "+")
                        result = firstNumber + secondNumber;
                    if (action == "-")
                        result = firstNumber - secondNumber;
                    if (action == "*")
                        result = firstNumber * secondNumber;
                    if (action == "/")
                        if (secondNumber == 0)
                            result = 0;
                        else
                            result = firstNumber / secondNumber;
                }
                Console.WriteLine("Result is " + Convert.ToString(result,2));
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter the first number ");
                firstNumber = Convert.ToInt32(Console.ReadLine(), 16);
                Console.WriteLine("Enter the second number ");
                secondNumber = Convert.ToInt32(Console.ReadLine(), 16);
                Console.WriteLine("Enter the required action ");
                action = Console.ReadLine();
                {
                    if (action == "+")
                        result = firstNumber + secondNumber;
                    if (action == "-")
                        result = firstNumber - secondNumber;
                    if (action == "*")
                        result = firstNumber * secondNumber;
                    if (action == "/")
                        if (secondNumber == 0)
                            result = 0;
                        else
                            result = firstNumber / secondNumber;
                }
                Console.WriteLine("Result is " + result.ToString("X"));
            }
            if (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Wrong input");
            }                               
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal Calculator,            press - 1 ");
            Console.WriteLine("Binary Number Calculator,      press - 2 ");
            Console.WriteLine("Hexadecimal number calculator, press - 3 ");

            NumberSystem numberSystem = new NumberSystem();
            numberSystem.choice = int.Parse(Console.ReadLine());
            numberSystem.Calculator();           
        }
    }
}