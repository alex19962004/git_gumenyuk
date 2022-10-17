
namespace ConsoleApp_9__Software__3_
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
        
        public override bool CanBeUsed(DateTime currentDatetime)
        {
           var maximumUsageDate = InstalledDate + UsagePeriod;
            if (currentDatetime > maximumUsageDate) return false;
            else return true;
            
        }

        public override string GetInfo()
        {            
            return $"{Name + " \t " + Producer + " \t " + InstalledDate + "\t" + " Use this for " + UsagePeriod}";
        }
    }
}
