namespace ConsoleApp_10__Person_IComparable_
{
    class Program
    {
        static void Main(string[] args)
        {           
            var persons = GetPerson();
            var currentPerson = new Person();
            
            for (int i = 0; i < persons.Length; i++)
            {
                int result = currentPerson.CompareTo(persons[i]);
                if (result == 0 )
                {
                    Console.WriteLine("name1, age1 = name2, age2" + " - " + currentPerson.Name + " " + currentPerson.Age + " " + persons[i].Name + " " + persons[i].Age);
                }
                else if (result == 1)
                {
                    Console.WriteLine("age1 > age2" + " - " + currentPerson.Name + " " + currentPerson.Age + " " + persons[i].Name + " " + persons[i].Age);
                }
                else if (result == -1)
                {
                    Console.WriteLine("age1 < age2" + " - " + currentPerson.Name + " " + currentPerson.Age + " " + persons[i].Name + " " + persons[i].Age);
                }
                else if (result == 2 )
                {
                    Console.WriteLine("age1 = age2" + " - " + currentPerson.Name + " " + currentPerson.Age + " " + persons[i].Name + " " + persons[i].Age);
                }              
            }          
        }

        public static Person[] GetPerson()
        {
            return new Person[]
            {
                new Person( "Vova", 36 ),
                new Person( "Kiril", 42 ),
                new Person( "Viktor", 45 ),
                new Person( "Kiril", 40 ),
                new Person( "Oleg", 42 )
            };
        }
    }
}