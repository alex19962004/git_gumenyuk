using System.Text.RegularExpressions;

namespace ConsoleApp7_1_
{
    class Work
    {
        public string surname;
        public string salary;
        public int amount;
        public bool result;
        public string[,] list;
        public void GetListOfEmployees()
        {
            list = new string[amount, 2];
            for (int i = 0; i < list.GetLength(0); i++)
            {
                Console.Write("Enter employee name ");
                surname = Console.ReadLine();
                string surnameLower = surname.ToLower();           
                bool surnameChek = Regex.IsMatch(surnameLower, "(^[a-z]+$)");
                if (surnameChek)
                {
                    string surnameUppe = Regex.Replace(surname, @"((^\w)|(\s|\p{P})\w)",
                           match => match.Value.ToUpper());
                    list[i,0] = surnameUppe;
                }                                                         
                else
                {
                    Console.WriteLine("Wrong input");  
                }                
                Console.Write("Enter employee salary ");
                salary = Console.ReadLine();
                bool check = Regex.IsMatch(salary, "(^[0-9]+$)");
                if (check)
                {
                    try
                    {
                        int salaryCheck = checked(int.Parse(salary));
                        if (salaryCheck < 0 || salaryCheck > 1000000)
                        {
                            Console.WriteLine("Error! Invalid value entered!!!");
                            salaryCheck = 0;
                        }                       
                        string salaryStr = Convert.ToString(salaryCheck);
                        list[i, 1] = salaryStr;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Error! Invalid value entered!!!");
                    }
                }
            }
        }    
        public void PrintListOfEmployees()
        {
            Console.WriteLine();
            Console.WriteLine("  LIST OF SALARY");
            Console.WriteLine(" Surname | Salary");
            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0; j < list.GetLength(1); j++)
                {                  
                    Console.Write("{0,-12}", list[i, j]);
                }
                Console.WriteLine();
            }
        }                
    }      
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Enter the amount of employees ");                     
            Work work = new Work();
            work.amount = int.Parse(Console.ReadLine());              
            work.GetListOfEmployees();   
            work.PrintListOfEmployees();
        }
    }
}