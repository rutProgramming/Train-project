using Train_project.classes;
using Train_project.DataContext;

namespace Train_project.services
{
    public class TrainService
    {
        public DataContextManager DataContextT { get; set; } = new DataContextManager();
        
        public List<Train> Get()
        {
            return DataContextT.Data_Context.Trains;
        }
        public Train GetById(int id)
        {
            return DataContextT.Data_Context.Trains.Find(train => train.TrainID == id);
        }
        public bool AddTrain(Train train)
        {
            DataContextT.Data_Context.Trains.Add(train);
            return true;
        }
        public bool UpdateTrain(int id,Train train)
        {
            int indexTrain=DataContextT.Data_Context.Trains.FindIndex(train=>train.TrainID == id);
            if (indexTrain != -1)
            {
                DataContextT.Data_Context.Trains[indexTrain]= train;
                return true;
            }
            return false;

        }
        public bool DeleteTrain(int id)
        {
            Train train = DataContextT.Data_Context.Trains.Find(train => train.TrainID == id);
            if (train != null)
            {
                DataContextT.Data_Context.Trains.Remove(train);
                return true;
            }
            return false;

        }
    }
}
