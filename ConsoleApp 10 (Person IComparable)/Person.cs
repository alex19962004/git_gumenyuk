using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp_10__Person_IComparable_
{
     public class Person: IComparable
    { 
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Kiril";
            Age = 42;           
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            int result;
    
           Person currentPerson = new Person();
           Person person = obj as Person;
            if (currentPerson.Name == person.Name && currentPerson.Age == person.Age)
                return result = 0;
            else if (currentPerson.Name == person.Name && currentPerson.Age > person.Age)
                return result = 1;
            else if (currentPerson.Name != person.Name && currentPerson.Age > person.Age)
                return result = 1;
            else if (currentPerson.Name == person.Name && currentPerson.Age < person.Age)
                return result = -1;
            else if (currentPerson.Name != person.Name && currentPerson.Age < person.Age)
                return result = -1;
            else if (currentPerson.Name != person.Name && currentPerson.Age == person.Age)
                return result = 2;
            else return result = 3;
        }      
    }
}
