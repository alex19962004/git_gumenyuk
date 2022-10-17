using ConsoleApp9_1_.Test;
using System.Windows.Markup;


namespace ConsoleApp9_1_
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
                new Free("FreeName1", "FreeProducer1"),
                new Free("FreeName2", "FreeProducer2"),
                new Trial("TrialName1", "TrialProducer1", DateTime.Now, TimeSpan.FromDays(2)),//can be used case
                new Trial("TrialName2", "TrialProducer2", new DateTime(2022, 10, 1), TimeSpan.FromDays(2))// can't not be used case
            };
        }
    }  
   
}