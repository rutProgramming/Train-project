
namespace Train_project.entities
{
    public class TrainRoute
    {
       
        public int IdRoute { get; set; }
        public int Driver { get; set; }
        public int Train { get; set; }
        public int Station { get; set; }
        public DateTime FirstTrain { get; set; }
        public DateTime LastTrain { get; set; }
        public int SubstituteDriver{ get; set; }
        public TrainRoute()
        {
                
        }

        public TrainRoute(int idRoute, int driver, int train, int station, DateTime firstTrain, DateTime lastTrain, int substituteDriver)
        {
            IdRoute = idRoute;
            Driver = driver;
            Train = train;
            Station = station;
            FirstTrain = firstTrain;
            LastTrain = lastTrain;
            SubstituteDriver = substituteDriver;
        }
    }
}
