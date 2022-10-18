namespace ConsoleApp10_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var person1 = new Person(34,"Oleg");
            var person2 = new Person(45, "Pavel");
            var result = person1.CompareTo(person2);

            Console.WriteLine(result);

            if (result == 0)
            {
                Console.WriteLine("name1, age1 = name2, age2" + " - " + person1.Name + " " + person1.Age + " " + person2.Name + " " + person2.Age);
            }
            else if (result == 1)
            {
                Console.WriteLine("age1 > age2" + " - " + person1.Name + " " + person1.Age + " " + person2.Name + " " + person2.Age);
            }
            else if (result == -1)
            {
                Console.WriteLine("age1 < age2" + " - " + person1.Name + " " + person1.Age + " " + person2.Name + " " + person2.Age);
            }
            else if (result == 2)
            {
                Console.WriteLine("age1 = age2" + " - " + person1.Name + " " + person1.Age + " " + person2.Name + " " + person2.Age);
            }         
        }
    }
    
}