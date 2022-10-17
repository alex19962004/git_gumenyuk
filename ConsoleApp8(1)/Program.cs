namespace ConsoleApp8_1_
{
    class DateTime
    {
        public DateTime()
        {
            //dayToday = 24;
            //monthToday = 08;
            //yeaToday = 1991;

            //dayToday = 21;
            //monthToday = 12;
            //yeaToday = 2112;
        }
        private int dayToday = 6;
        private int monthToday = 10;
        private int yeaToday = 2022;

        public int dayRequired;
        public int monthRequired;
        public int yearRequired;

        public int dayFound;
        public int monthFound;
        public int yearFound;

        protected int amountOfDaysAMonth = 0;
        private int leapYearСoefficient = 4;
       
        public void GetDateOfPreviousDay()
        {
            Console.Write("Enter required date - 00 days ago  ");
            dayRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter required date - 00 months ago  ");
            monthRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter required date - 00 years ago  ");
            yearRequired = int.Parse(Console.ReadLine());

            yearFound = yeaToday - yearRequired;

            monthFound = monthToday - monthRequired;
            while (monthFound <= 0)
            {
                if (monthFound > -12)
                {
                    monthFound += 12;
                    yearFound--;
                    break;
                }
                monthFound += 12;
                yearFound--;
            }

            dayFound = dayToday - dayRequired;
            while (dayFound <= 0)
            {
                monthFound--;
                if (monthFound == 0)
                    monthFound = 12;
                if (monthFound == 1 || monthFound == 3 || monthFound == 5 || monthFound == 7 || monthFound == 8 || monthFound == 10 || monthFound == 12)
                    amountOfDaysAMonth = 31;
                if (monthFound == 4 || monthFound == 6 || monthFound == 9 || monthFound == 11)
                {
                    amountOfDaysAMonth = 30;
                }
                if (monthFound == 2)
                {
                    amountOfDaysAMonth = 28;
                }

                if (monthFound == 2 && yearFound % leapYearСoefficient == 0)
                {
                    amountOfDaysAMonth = 29;
                }
                dayFound += amountOfDaysAMonth;
            }
            Console.WriteLine();
            string fmt = "00.##";
            string fmt2 = "0000.##";
            //Console.WriteLine(dayFound.ToString(fmt) + "." + monthFound.ToString(fmt) + "." + yearFound);
            // dateTime = new string[5];
            string[] dateTime = { dayFound.ToString(fmt), ".", monthFound.ToString(fmt), ".", yearFound.ToString(fmt2) };
            for (int i = 0; i < 5; i++)
            {
                Console.Write(dateTime[i]);
            }
        }
        public void GetDateOfNextDay()
        {
            Console.Write("Enter required date - 00 days next  ");
            dayRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter required date - 00 months next  ");
            monthRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter required date - 00 years next  ");
            yearRequired = int.Parse(Console.ReadLine());

            yearFound = yeaToday + yearRequired;

            monthFound = monthToday + monthRequired;
            while (monthFound > 12)
            {
                monthFound -= 12;
                yearFound++;
            }

            dayFound = dayToday + dayRequired;
            while (dayFound > amountOfDaysAMonth)
            {
                if (monthFound == 1 || monthFound == 3 || monthFound == 5 || monthFound == 7 || monthFound == 8 || monthFound == 10 || monthFound == 12)
                    amountOfDaysAMonth = 31;
                if (monthFound == 4 || monthFound == 6 || monthFound == 9 || monthFound == 11)
                {
                    amountOfDaysAMonth = 30;
                }
                if (monthFound == 2)
                {
                    amountOfDaysAMonth = 28;
                }

                if (monthFound == 2 && yearFound % leapYearСoefficient == 0)
                {
                    amountOfDaysAMonth = 29;
                }
                if (dayFound <= amountOfDaysAMonth)
                {
                    break;
                }
                if (dayFound > amountOfDaysAMonth)
                {
                    dayFound -= amountOfDaysAMonth;
                    monthFound++;
                    if (monthFound == 13)
                    {
                        monthFound = 1;
                        yearFound++;
                    }
                }
            }
            Console.WriteLine();
            string fmt = "00.##";
            string fmt2 = "0000.##";
            string[] dateTime = { dayFound.ToString(fmt), ".", monthFound.ToString(fmt), ".", yearFound.ToString(fmt2) };
            for (int i = 0; i < 5; i++)
            {
                Console.Write(dateTime[i]);
            }

        }
        public void GetDaysLeftUntilEndMonth()
        {
            Console.Write("Enter required date - 00 days  ");
            dayRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter required date - 00 months  ");
            monthRequired = int.Parse(Console.ReadLine());
            Console.Write("Enter required date - 00 years  ");
            yearRequired = int.Parse(Console.ReadLine());

            yearFound = yearRequired;

            monthFound = monthRequired;
                       
            while (dayRequired > amountOfDaysAMonth)
            {
                if (monthFound == 1 || monthFound == 3 || monthFound == 5 || monthFound == 7 || monthFound == 8 || monthFound == 10 || monthFound == 12)
                    amountOfDaysAMonth = 31;
                if (monthFound == 4 || monthFound == 6 || monthFound == 9 || monthFound == 11)
                {
                    amountOfDaysAMonth = 30;
                }
                if (monthFound == 2)
                {
                    amountOfDaysAMonth = 28;
                }

                if (monthFound == 2 && yearFound % leapYearСoefficient == 0)
                {
                    amountOfDaysAMonth = 29;
                }

                dayFound = amountOfDaysAMonth - dayRequired;
                
            }
            Console.WriteLine();
            string fmt = "00.##";
            //Console.WriteLine(dayFound.ToString(fmt);
            string[] dateTime = { dayFound.ToString(fmt), " ", "days left until the end of the month" };
            for (int i = 0; i < 3; i++)
            {
                Console.Write(dateTime[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine("If you want the Future - press  +  ");
            Console.WriteLine("If you want the Past - click  -  ");
            Console.WriteLine("If you want to calculate the number of days left until the end of the month. - press  = ");
            string action = Console.ReadLine();
             
            if (action == "+")
            {
                dateTime.GetDateOfNextDay();
                Console.WriteLine();
            }            
            
            if (action == "-") 
            {  
                dateTime.GetDateOfPreviousDay();
                Console.WriteLine();
            }                    
           
            if (action == "=")
            {
                dateTime.GetDaysLeftUntilEndMonth();
                Console.WriteLine();
            }          
        }
    }
}