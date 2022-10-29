
namespace ConsoleApp_13__2__Exception_CustomException
{
     class Methods
    {
        public static int c;
        

        public static int Sum(int a, int b)
        {
           
                if (a == 0 && b != 0)
                {
                    throw new ArithmeticException();
                }
                else
                {
                    c = a + b;
                }            
            return c;
        }
        public static int Subtraction(int a, int b)
        {
            
                if (a != 0 && b == 0)
                {
                    throw new ArithmeticException();
                }
                else
                    c = a - b;          
            return c;
        }
        public static int Multiplication(int a, int b)
        {
            if (a < 0 && b < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
                c = a * b;
            return c;
        }
        public static int Division(int a, int b)
        {          
                if (a == 0 && b == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                    c = a / b;           
            return c;
        }
    }
}
