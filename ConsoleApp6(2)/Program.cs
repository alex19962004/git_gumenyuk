namespace ConsoleApp6_2_
{
    class Temperature
    {
        public double celsius;
        public double fahenreit;
        public double kelvin;
        public int choice;

        public void TemperatureConverter()
        {
            if (choice == 1)
            {
                Console.Write("Enter temperature in Celsius = ");
                celsius = Convert.ToDouble(Console.ReadLine());
                fahenreit = celsius * 9.0 / 5.0 + 32;
                Console.WriteLine("Result in Fahenreit  = " + fahenreit);
                kelvin = celsius + 273.15;
                Console.WriteLine("Result in Kelvin = " + kelvin);
            }
            if (choice == 2)
            {
                Console.Write("Enter temperature in Fahenreit = ");
                fahenreit = Convert.ToDouble(Console.ReadLine());
                celsius = (fahenreit - 32) * 5.0 / 9.0;
                Console.WriteLine("Result in Celsius  = " + celsius);
                kelvin = (fahenreit - 32) * 5.0 / 9.0 + 273.15;
                Console.WriteLine("Result in Kelvin = " + kelvin);
            }
            if (choice == 3)
            {
                Console.Write("Enter temperature in Kelvin = ");
                kelvin = Convert.ToDouble(Console.ReadLine());
                celsius = kelvin - 273.15;
                Console.WriteLine("Result in Celsius  = " + celsius);
                fahenreit = kelvin * 9.0 / 5.0 - 459.67;
                Console.WriteLine("Result in Fahenreit = " + fahenreit);
            }
            if (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Wrong input");
            }           
        }             
    }
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Convert Celsius to Fahrenheit and Kelvin, press - 1 ");
            Console.WriteLine("Convert Fahrenheit to Celsius and Kelvin, press - 2 ");
            Console.WriteLine("Convert Kelvin to Celsius and Fahrenheit, press - 3 "); 
            Temperature temp = new Temperature();           
            temp.choice = int.Parse(Console.ReadLine());
            temp.TemperatureConverter();
           
        }
    }
}