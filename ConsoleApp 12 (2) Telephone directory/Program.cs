namespace ConsoleApp_12__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string number;
            string lookingForSurnamePerson;
            var library = new Library();

            NumberType numberType = new NumberType();
            Console.WriteLine(" Select the Сaller search option ");
            Console.WriteLine(" - by Surname            - enter - 0 ");
            Console.WriteLine(" - by Mobilenumber type  - enter - 1");
            Console.WriteLine(" - by Worknumber type    - enter - 2");
            Console.WriteLine(" - by Oficialnumber type - enter - 3");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Enter Surname of the person you are looking for...");
                    lookingForSurnamePerson = Console.ReadLine();
                    Console.WriteLine(library.SearchByName(lookingForSurnamePerson));
                    break;
                case "1":
                    numberType = (NumberType)1;                    
                    Console.WriteLine("Enter a phone number in the format +38...");
                    break;
                case "2":
                    numberType = (NumberType)2;
                    Console.WriteLine("Enter a phone number in the format +38044...");
                    break;
                case "3":
                    numberType = (NumberType)3;
                    Console.WriteLine("Enter a phone number in the format +38...");
                    break;
                default:
                    Console.WriteLine("Wrong input...");
                    break;
            }

            number = Console.ReadLine();
            Console.WriteLine(library.SearchByNumber(numberType, number));
           
        }
    }
}