namespace ConsoleApp_9__Software__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentDate = DateTime.Now;
            var softwares = GetSoftwares();
            var validSoftwares = softwares.Where(s => s.CanBeUsed(currentDate));
          
           
            foreach (var item in validSoftwares)
                Console.WriteLine(item.GetInfo());

        }

        public static Software[] GetSoftwares()
        {
            return new Software[]
            {           
                new Free("Microsoft Visual Studio Enterprise 2019", "Microsoft"),
                new Free("Microsoft Outlook 2021", "Microsoft"),
                new Free("PDF Suite Standard", "Adobe Systems"),

                new Trial("Microsoft SQL Server 2019", "Microsoft", DateTime.Now, TimeSpan.FromDays(120)),                  //can be used case
                new Trial("Nuance Power PDF", "Nuance Communications", new DateTime(2022, 09, 14), TimeSpan.FromDays(30)),   // can't be used case
                new Trial("Microsoft Windows Server 2022", "Microsoft", new DateTime(2022, 08, 20), TimeSpan.FromDays(90)), //can be used case
            
                new Commercial("Microsoft Office Home & Business 2021", "Microsoft", DateTime.Today, TimeSpan.FromDays(60), 44),  //can be used case
                new Commercial("AVAST Driver Updater", "Avast Software", new DateTime(2022, 10, 4), TimeSpan.FromDays(30), 15),   // can't be used case
                new Commercial("ESET NOD32 Antivirus", "ESET", new DateTime(2022, 07, 16), TimeSpan.FromDays(180), 57)            //can be used case
            };
        }
    }
}