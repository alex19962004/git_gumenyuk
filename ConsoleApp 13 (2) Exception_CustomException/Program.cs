using System.Text.RegularExpressions;

namespace ConsoleApp_13__2__Exception_CustomException
{
    internal class Program
    {
        public static int a;
        public static int b;
        static void Main(string[] args)
        {
            string choice;
            string aStr;
            string bStr;
            while (true)
            {
                try
                {
        Console.Write("Enter the first number ...");
                    while (true)
                    {
                        try
                        {
                            aStr = Console.ReadLine();
                           bool check = Regex.IsMatch(aStr, "(^[0-9]+$)");                           
                           if(check != true)
                            {
                                throw new CustomException("CustomException!!!");
                            } 
                            a = int.Parse(aStr);
                        }
                        catch (CustomException)
                        {
                            Console.WriteLine("Wrong input, you didn't enter number!!!");
                            Console.Write("Re-enter the first number ...");
                            continue;
                        }
                        break;
                    }

                    Console.Write("Enter the second number ...");
                    while(true)
                    {
                        try
                        {
                            bStr = Console.ReadLine();
                            bool check = Regex.IsMatch(bStr, "(^[0-9]+$)");
                            if (check != true)
                            {
                                throw new CustomException("CustomException!!!");
                            }
                            b = int.Parse(bStr);
                        }
                        catch (CustomException)
                        {
                            Console.WriteLine("Wrong input, you didn't enter numbers!!!");
                            Console.Write("Re-enter the second number ...");                   
                            continue;
                        }
                        break;
                    }
                   
                    Console.Write("Enter an arithmetic operation (+, -, *, /) ...");
                    while (true)
                    {
                        try
                        {
                            choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "+":
                                    Console.WriteLine("Result = " + Methods.Sum(a, b));
                                    break;
                                case "-":
                                    Console.WriteLine("Result = " + Methods.Subtraction(a, b));
                                    break;
                                case "*":
                                    Console.WriteLine("Result = " + Methods.Multiplication(a, b));
                                    break;
                                case "/":
                                    Console.WriteLine("Result = " + Methods.Division(a, b));
                                    break;
                                default:
                                    throw new OperationCanceledException();
                            }
                        }
                        catch (OperationCanceledException)
                        {
                            Console.WriteLine("Wrong input, you didn't enter an arithmetic operation (+, -, *, /) !!!");
                            Console.Write("Re-enter an arithmetic operation (+, -, *, /) ...");
                            continue;
                        }               
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Argument out of range!!! ");
                    continue;
                } 
                catch (DivideByZeroException)            
                {
                    Console.WriteLine("Division by 0 is impossible!!! ");
                    continue;
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("Arithmetic exception!!! ");
                    continue ;
                }               
                break;
            }            
        }       
    }
}