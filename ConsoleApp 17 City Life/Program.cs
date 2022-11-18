namespace ConsoleApp_17_City_Life
{
     class Program
    {
        static void Main(string[] args)
        {
            Police police = new Police();
            Ambulance ambulance = new Ambulance();
            FireDepartment fireDepartment = new FireDepartment();

            CityLifeEvents city = new CityLifeEvents();

            Random random = new Random();
            int randomEvents = random.Next(100);
               if (randomEvents <= 60)
               {
                    police.PoliceAction(" ");
               }
               if (randomEvents > 60 && randomEvents <= 80)
               {
                    ambulance.AmbulanceAction();
               }
               if (randomEvents > 80)
               {
                    fireDepartment.FireDepartmentAction();
               }
            CityLifeEventsHandler cityLife = new CityLifeEventsHandler( police.PoliceAction);
            Console.WriteLine(cityLife);

        }
    }
}