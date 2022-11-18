namespace ConsoleApp_17__2__City_Life
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();

            Random random = new Random();
            int randomEvents = random.Next(100);
            if (randomEvents <= 40)
            {
                IncidentMessage incidentMessage1 = new IncidentMessage("121", "accident, police needed", "6, Stepova street", DepartmentType.Police);
                city.RaiseAnIncident(incidentMessage1);
                Console.WriteLine("The police are already on their way!");
                Console.WriteLine("The police arrived at the scene!");
            }
            if (randomEvents > 40 && randomEvents <= 60)
            {
                IncidentMessage incidentMessage1 = new IncidentMessage("121", "car accident with injured", "6, Stepova street", DepartmentType.Police);
                city.RaiseAnIncident(incidentMessage1);
                Console.WriteLine("Police call an ambulance!");
                IncidentMessage incidentMessage4 = new IncidentMessage("121", "car accident with injured", "6, Stepova street", DepartmentType.Ambulance);
                city.RaiseAnIncident(incidentMessage4);
                Console.WriteLine("The police and ambulance are already on their way!");
                Console.WriteLine("The police arrived at the scene!");
                Console.WriteLine("The ambulance arrived at the scene!");
                Console.WriteLine("Providing medical assistance to the victims!");
            }
            if (randomEvents > 60 && randomEvents <= 80)
            {
                IncidentMessage incidentMessage2 = new IncidentMessage("131", "fire", "6, Stepova street", DepartmentType.FireStation);
                city.RaiseAnIncident(incidentMessage2);
                Console.WriteLine("The fire brigate are already on their way!");
                Console.WriteLine("The fire brigate arrived at the scene!");
                Console.WriteLine("Firefighters begin to put out the fire!");
            }
            if (randomEvents > 80)
            {
                IncidentMessage incidentMessage3 = new IncidentMessage("141", "accident, need an ambulance", "6, Stepova street", DepartmentType.Ambulance);
                city.RaiseAnIncident(incidentMessage3);
                Console.WriteLine("The ambulance are already on their way!");
                Console.WriteLine("The ambulance arrived at the scene!");
                Console.WriteLine("Providing medical assistance to the victims!");
            }
        }
    }
}