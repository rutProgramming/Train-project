using Train_project.classes;
using Train_project.DataContext;

namespace Train_project.services
{
    public class StationService
    {
        public DataContextManager DataContextS { get; set; } = new DataContextManager();
        valid valid=new valid();
        public List<Station> Get()
        {
            return DataContextS.Data_Context.Stations;
        }
        public Station GetById(int id)
        {
            return DataContextS.Data_Context.Stations.Find(station => station.StationID == id);
        }
        public bool AddStation(Station station)
        {
            if (valid.IsValidGPSCoordinates(station.LocationGPSCoordinates) )
            {
                DataContextS.Data_Context.Stations.Add(station);
                return true;
            }
            return false;
        }
        public bool UpdateStation(int id, Station station)
        {
            int indexTrainRoute = DataContextS.Data_Context.Stations.FindIndex(station => station.StationID == id);
            if (indexTrainRoute != -1)
            {
                DataContextS.Data_Context.Stations[indexTrainRoute] = station;
                return true;
            }
            return false;

        }
        public bool DeleteStation(int id)
        {
            Station station = DataContextS.Data_Context.Stations.Find(station => station.StationID == id);
            if (station != null)
            {
                DataContextS.Data_Context.Stations.Remove(station);
                return true;
            }
            return false;

        }
    }
}
