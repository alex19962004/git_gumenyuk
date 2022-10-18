
namespace ConsoleApp10_1_
{
    public class Person : IComparable<Person>
    { 
        public int Age { get; set; }
        public string Name { get; set; }
       
        public Person(int age, string name)
        {
            Age = age;
            Name = name;           
        }

        public static bool operator > (Person person1, Person person2)
        {
            return person1.Age > person2.Age;
        }
        public static bool operator < (Person person1, Person person2)
        {
            return person1.Age < person2.Age;
        }
        public static bool operator == (Person person1, Person person2)
        {
             return person1.Age == person2.Age && person1.Name == person2.Name;
        }

        public static bool operator != (Person person1, Person person2)
        {
            return person1.Age != person2.Age && person1.Name != person2.Name;
        }
        
        public int CompareTo(Person? other)
        {
            if (this > other) return 1;
             else if (this < other) return -1;
             else if (this == other) return 0;
             else if (this != other) return 2;
             else return 3;
        }
    }
}
