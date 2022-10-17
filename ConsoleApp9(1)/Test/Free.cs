using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_1_.Test
{
    public class Free : Software
    {
        public Free(string name, string producer) : base(name, producer)
        {
        }

        public override bool CanBeUsed(DateTime time)
        {
            return true;
        }

        public override string GetInfo()
        {
            return Producer + " - " + Name;
        }
    }
}
