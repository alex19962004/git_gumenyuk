
namespace ConsoleApp_17__2__City_Life
{
    public class City
    {
        private delegate void CityHandler(IncidentMessage incident);
        private event CityHandler PoliceEvent;
        private event CityHandler FireStationEvent;
        private event CityHandler AmbulanceEvent;       

        public City()
        {
            PoliceEvent = OnPoliceEvent;
            FireStationEvent = OnFireStationEvent;
            AmbulanceEvent = OnAmbulanceEvent;
        }

        public void RaiseAnIncident(IncidentMessage incident)
        {
            switch (incident.DepartmentType)
            {
                case DepartmentType.Police:
                    PoliceEvent?.Invoke(incident);
                    break;
                case DepartmentType.FireStation:
                    FireStationEvent?.Invoke(incident);
                    break;
                case DepartmentType.Ambulance:
                    AmbulanceEvent?.Invoke(incident);
                    break;
                default:
                    throw new ArgumentException("Not exist department type");
            }
        }

        private void OnPoliceEvent(IncidentMessage incident)
        {
            var police = new Police(incident.Id, incident.Description, incident.Address);
            police.Call();
        }

        private void OnFireStationEvent(IncidentMessage incident)
        {
            var fireStation = new FireStation(incident.Id, incident.Description, incident.Address);
            fireStation.Call();
        }

        private void OnAmbulanceEvent(IncidentMessage incident)
        {
            var ambulance = new Ambulance(incident.Id, incident.Description, incident.Address);
            ambulance.Call();
        }
    }
}
