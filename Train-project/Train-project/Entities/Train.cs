namespace Train_project.classes
{
    public class Train
    {
        
        public int TrainID{ get; set; }
        public int TrainLine{ get; set; }
        public int NumberOfCars { get; set; }
        public bool TrainStatus{ get; set; }
        public string RegularRoute{ get; set; }
        public string Model { get; set; }
        public DateTime ServiceDate { get; set; }
        public Train()
        {
            
        }
        public Train(int trainID, int trainLLine, int numberOfCars, bool trainStatus, string regularRoute, string model, DateTime serviceDate)
        {
            TrainID = trainID;
            TrainLine = trainLLine;
            NumberOfCars = numberOfCars;
            TrainStatus = trainStatus;
            RegularRoute = regularRoute;
            Model = model;
            ServiceDate = serviceDate;
        }
    }
}
