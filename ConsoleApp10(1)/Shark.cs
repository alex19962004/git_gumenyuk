using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10_1_
{
    public class Shark : IComparable<Shark>
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Shark(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public static bool operator >(Shark shark1, Shark shark2)
        {
            return shark1.Age > shark2.Age;
        }

        public static bool operator <(Shark shark1, Shark shark2)
        {
            return shark1.Age < shark2.Age;
        }

        public static bool operator ==(Shark shark1, Shark shark2)
        {
            return shark1.Age == shark2.Age && shark1.Name == shark2.Name;
        }

        public static bool operator !=(Shark shark1, Shark shark2)
        {
            return shark1.Age != shark2.Age && shark1.Name != shark2.Name;
        }
        public int CompareTo(Shark? other)
        {
            if (this > other)
                return 1;
            else if (this < other)
                return -1;
            else if (this == other)
                return 0;
            else
                return 2;
        }
    }

    public class MainShark
    {
        public void Do()
        {
            var shark1 = new Shark(22, "Shark1");
            var shark2 = new Shark(50, "Shark2");
            var resCompare = shark1 > shark2;

            var result = shark1.CompareTo(shark2);
            var data = new Shark[] { shark1, shark2, shark1 };
        }

        public void Mainint(Shark[] sharks)
        {
            for (var i = 0; i < sharks.Length; i++)
            {
                var shark1 = sharks[i];
                for (var j = i + 1; j < sharks.Length; j++)
                {
                    var shark2 = sharks[j];
                    var result = shark1.CompareTo(shark2);
                }
            }
        }
    }
}
