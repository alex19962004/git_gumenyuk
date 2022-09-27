namespace ConsoleApp4_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*string computerPassword = "administrator";
            Console.WriteLine("Enter password ...");
            string password = Console.ReadLine();             
                 while (password != computerPassword)
                     {
                        Console.WriteLine("Enter password ...");
                        password = Console.ReadLine();
                      }                     
            Console.WriteLine("You are authorized as an administrator");*/

            string computerPassword = "administrator";
            string password;
            do
            {
                Console.WriteLine("Enter password ...");
                password = Console.ReadLine();
            }
            while (password != computerPassword);           
            Console.WriteLine("You are authorized as an administrator");
        }
    }
}