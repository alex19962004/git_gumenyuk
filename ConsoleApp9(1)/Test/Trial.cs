using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_1_.Test
{
    public class Trial : Software
    {
        public Trial(string name, string producer, DateTime installedDate, TimeSpan usagePeriod) : base(name, producer)
        {
            InstalledDate = installedDate;
            UsagePeriod = usagePeriod;
        }

        public DateTime InstalledDate { get; set; }
        public TimeSpan UsagePeriod { get; set; }

        public override bool CanBeUsed(DateTime time)
        {
            return true;
        }

        public override string GetInfo()
        {
            //var result = string.Format(Producer, " - ", Name, Price.ToString("0.00"));
            return Producer + " - " + Name + " - Use this to " + UsagePeriod;
        }
    }
}
