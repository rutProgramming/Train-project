namespace Train_project.classes
{
    public enum  StationType { UrbanStation, IntercityStation }
    public class Station
    {
        
        public int StationID { get; set; }
        public string StationName { get; set; }
        public string StationAddress { get; set; }
        public string StationCity { get; set; }
        public string LocationGPSCoordinates{ get; set; }
        public StationType StationType { get; set; }
        public int NumberOfPlatforms { get; set; }
        public Station()
        {
            
        }

        public Station(int stationID, string stationName, string stationAddress, string stationCity, string locationGPSCoordinates, StationType stationType, int numberOfPlatforms)
        {
            StationID = stationID;
            StationName = stationName;
            StationAddress = stationAddress;
            StationCity = stationCity;
            LocationGPSCoordinates = locationGPSCoordinates;
            StationType = stationType;
            NumberOfPlatforms = numberOfPlatforms;
        }
    }
}
