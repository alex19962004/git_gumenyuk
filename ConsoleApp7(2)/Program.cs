using System.Text.RegularExpressions;


namespace ConsoleApp7_2_
{
    enum Brand
    {
        Toyota,
        Volkswagen,
        Ford,
        Nissan,
        Honda,
        Hyundai,
        Kia,
        Mercedes,
        Audi,
        Mazda
    }
    class Car
    {
        public string word;
        public string wordUpper;
        public string letters;
        public string lettersUpper;
        public string lastLettersUpper;
        public string ownerSurname;
        public string ownerName;
        public string brand;
        public Brand brandCars;
        public string year;
        public ushort yearNumber;
        public int amount;
        public string numbers;
        public string numbersCheck;
        public string[,] list;

        public void WordCheckUpper()
        {
            string wordLower = word.ToLower();
            bool wordChek = Regex.IsMatch(wordLower, "(^[a-z]+$)");
            if (wordChek)
            {
                wordUpper = Regex.Replace(wordLower, @"((^\w)|(\s|\p{P})\w)",
                       match => match.Value.ToUpper());
            }
            else
            {
                Console.WriteLine("Wrong input");
                Console.Write("Enter of car owner's surname/name ");
                word = Console.ReadLine();
                WordCheckUpper();
            }
        }
        public void LettersCheckUpper()
        {
            int length = letters.Length;
            bool lettersChek = Regex.IsMatch(letters, "(^[a-zA-Z]+$)");
            if (lettersChek && length ==2)
            {
                lettersUpper = letters.ToUpper();
            }
            else
            {
                Console.WriteLine("Wrong input");
                Console.Write("Re-enter letters ");
                letters = Console.ReadLine();
                LettersCheckUpper();
            }
        }
        public void NumbersCheck()
        {
            int length = numbers.Length;
            bool check = Regex.IsMatch(numbers,"(^[0-9]+$)");
            if (check && length == 4)
            {
                numbersCheck =numbers;
            }           
            else
            {
                Console.WriteLine("Wrong input");
                Console.Write("Re-enter numbers ");
                numbers = Console.ReadLine();
                NumbersCheck();
            }
        }
        public void GetListOfCarOwners()
        {

            list = new string[amount, 7];
            for (int i = 0; i < list.GetLength(0); i++)
            {
                Console.Write("Enter of car owner's surname ");
                word = Console.ReadLine();
                WordCheckUpper();
                ownerSurname = wordUpper;
                list[i, 0] = ownerSurname;

                Console.Write("Enter of car owner's name ");
                word = Console.ReadLine();
                WordCheckUpper();
                ownerName = wordUpper;              
                list[i, 1] = ownerName;

                while (list[i, 2] == null)
                {
                    Console.Write("Enter of car brand ");                            
                    brand = Console.ReadLine();                
                    string brandUppe = Regex.Replace(brand, @"((^\w)|(\s|\p{P})\w)",
                    match => match.Value.ToUpper());
                    foreach (string brandCar in Enum.GetNames(typeof(Brand)))
                    
                    if (brandCar == brandUppe)
                    {
                        list[i, 2] = brandUppe;
                        break;
                    }                   
                    Console.WriteLine("Wrong input");
                }
                                                  
                Console.Write("Enter the first two letters of the car's registration number, for example, as - AA ");
                letters = Console.ReadLine();
                LettersCheckUpper();
                list[i, 3] = lettersUpper;

                Console.Write("Enter four digits of the car's registration number, for example, as - 2222 ");
                numbers = Console.ReadLine();
                NumbersCheck();
                string numbersCheckNumber = numbersCheck;
                list[i, 4] = numbersCheckNumber;

                Console.Write("Enter the last two letters of the car's registration number, for example, as - BB ");
                letters = Console.ReadLine();
                LettersCheckUpper();
                lastLettersUpper = lettersUpper;
                list[i, 5] = lastLettersUpper;


                while(list[i, 6] == "0" || list[i,6] == null )
                {
                    Console.Write("Enter year of manufacture of the car ");
                    numbers = Console.ReadLine();
                    NumbersCheck();
                    year = numbersCheck;
                    DateTime dateTime = DateTime.Now;
                    int yearСurrent = dateTime.Year;
                    try
                    {
                        yearNumber = checked(ushort.Parse(year));
                        if (yearNumber < 1990 || yearNumber > yearСurrent)
                        {
                            Console.WriteLine("Error! Invalid year entered!!!");
                            yearNumber = 0;
                        }
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Error! Invalid year entered!!!");
                    }
                    string yearStr = Convert.ToString(yearNumber);
                    list[i, 6] = yearStr;
                }
                
            }
        }
        public void PrintListOfCarOwners()
        {
            Console.WriteLine();
            Console.WriteLine("       LIST OF CAR OWNERS");
            Console.WriteLine("OwnerSurname| OwnerName  |    Brand     |Registration number| Year");
            for (int i = 0; i < list.GetLength(0); i++)
            {
                for (int j = 0; j < list.GetLength(1); j++)
                {
                     if(j <= 2)
                         Console.Write(String.Format("{0,-14}", list[i, j]));
                     if(j ==3)
                         Console.Write(String.Format("{0,-3}", list[i, j]));
                    if (j == 4)
                        Console.Write(String.Format("{0,-5}", list[i, j]));
                    if (j == 5)
                        Console.Write(String.Format("{0,-8}", list[i, j]));
                    if (j == 6)
                         Console.Write(String.Format("{0,-6}", list[i, j]));                   
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of car owners ");
            Car car = new Car();
            car.amount = int.Parse(Console.ReadLine());          
            car.GetListOfCarOwners();
            car.PrintListOfCarOwners();            
        }
    }
}