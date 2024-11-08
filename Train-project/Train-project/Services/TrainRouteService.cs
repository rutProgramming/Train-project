using Train_project.classes;
using Train_project.DataContext;
using Train_project.entities;

namespace Train_project.services
{
    public class TrainRouteService
    {
        public DataContextManager DataContextTR { get; set; } = new DataContextManager();
        valid valid=new valid();
        public List<TrainRoute> Get()
        {
            return DataContextTR.Data_Context.TrainRoutes;
        }
        public TrainRoute GetById(int id)
        {
            return DataContextTR.Data_Context.TrainRoutes.Find(trainRoute => trainRoute.IdRoute == id);
        }
        public bool AddTrainRoute(TrainRoute trainRoute)
        {
            if (valid.LastTimeAfterFirstTime(trainRoute.FirstTrain, trainRoute.LastTrain))
            { 
                DataContextTR.Data_Context.TrainRoutes.Add(trainRoute);
                return true;
            }
            return false;
        }
        public bool UpdateTrainRoute(int id, TrainRoute trainRoute)
        {
            int indexTrainRoute = DataContextTR.Data_Context.TrainRoutes.FindIndex(trainRoute => trainRoute.IdRoute == id);
            if (indexTrainRoute != -1)
            {
                DataContextTR.Data_Context.TrainRoutes[indexTrainRoute] = trainRoute;
                return true;
            }
            return false;

        }
        public bool DeleteTrainRoute(int id)
        {
            TrainRoute trainRoute = DataContextTR.Data_Context.TrainRoutes.Find(trainRoute => trainRoute.IdRoute == id);
            if (trainRoute != null)
            {
                DataContextTR.Data_Context.TrainRoutes.Remove(trainRoute);
                return true;
            }
            return false;

        }
    }
}

