
namespace ConsoleApp_9__Software__3_
{
    public class Commercial : Software
    {
       
        public Commercial(string name, string producer, DateTime installedDate, TimeSpan usagePeriod, decimal price ) : base(name, producer)
        {
            InstalledDate = installedDate;
            UsagePeriod = usagePeriod;
            Price = price;
        }
        public decimal Price { get; set; }
        public DateTime InstalledDate { get; set; }

        public TimeSpan UsagePeriod { get; set; }
        
        

        public override bool CanBeUsed (DateTime currentDatetime)
        {
            var maximumUsagedata = InstalledDate + UsagePeriod;
            if (currentDatetime > maximumUsagedata) return false;
            else return true;
        }
        public override string GetInfo()
        {
            return $"{ Name + " \t " + Producer + " \t " + InstalledDate + "\t" + "Use this for " + UsagePeriod + "\t " + Price.ToString("0.00")}";
        }




    }
}
