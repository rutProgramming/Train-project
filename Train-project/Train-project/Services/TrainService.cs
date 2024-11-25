using Train_project.classes;
using Train_project.Data;
using Train_project.DataContext;

namespace Train_project.services
{
    public class TrainService
    {
        readonly ITrainDataContext _TrainDataContext;
        public TrainService(ITrainDataContext trainDataContext)
        {
            _TrainDataContext = trainDataContext;
        }
        public List<Train> Get()
        {
            var TrainData=_TrainDataContext.LoadData();
            if (TrainData == null) {return null;}
            return TrainData;
        }
        public Train GetById(int id)
        {
            var TrainData= _TrainDataContext.LoadData();
            if (TrainData == null) { return null; }
            return TrainData.Where(train => train.TrainID == id).FirstOrDefault();
        }
        public bool AddTrain(Train train)
        {
            var trainData= _TrainDataContext.LoadData();
            if (trainData == null) 
            { 
               trainData = new List<Train>();
            }
            trainData.Add(train);
            _TrainDataContext.SaveData(trainData);
            return true;
        }
        public bool UpdateTrain(int id,Train train)
        {
            List<Train> data= _TrainDataContext.LoadData();
            if (data == null) {return false;}
            int indexTrain= data.FindIndex(train => train.TrainID == id);
            if (indexTrain != -1)
            {
                data[indexTrain] = train;
                _TrainDataContext.SaveData(data);
                return true;
            }
            return false;

        }
        public bool DeleteTrain(int id)
        {
            var data= _TrainDataContext.LoadData();
            if(data == null)return false;
            Train train = data.FirstOrDefault(train => train.TrainID == id);
            if (train != null)
            {
                data.Remove(train);
                _TrainDataContext.SaveData(data);
                return true;
            }
            return false;

        }
    }
}
