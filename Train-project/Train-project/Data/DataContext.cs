using Train_project.classes;
using Train_project.entities;

namespace Train_project.DataContext
{
    public class DataContext
    {
        public List<Employee> Employees { get; set; }
        public List<PublicInquiry> PublicInquiries { get; set; }
        public List<Station> Stations { get; set; }
        public List<Train> Trains { get; set; }
        public List<TrainRoute> TrainRoutes { get; set; }


        public DataContext()
        {
            Employees = new List<Employee> { new Employee(  1, "21212",  "moshe", "45454", typeWork.driver, "street1", 10000,  new DateTime(2024, 12, 01) ) };
            PublicInquiries = new List<PublicInquiry> { new PublicInquiry(1, 1, new DateTime(2023, 1, 13), "blablanla", false, 1, "yakov", "23233") };   
            Stations = new List<Station> { new Station ( 1, "lkl", "hjhj", "bn", "41.40338, 2.17403", StationType.IntercityStation,  3  )};
            Trains = new List<Train> { new Train ( 1, 12,  2, true, "Jerusalem-TelAviv", "mer", new DateTime(2020, 04, 5) ) };
            TrainRoutes = new List<TrainRoute> { new TrainRoute ( 1, 1,1,1,  new DateTime(2024, 11, 7, 7, 30, 0),  new DateTime(2024, 11, 7, 23, 30, 0),  2 ) };
        }
    }
}
