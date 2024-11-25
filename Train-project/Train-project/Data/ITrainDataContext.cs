using System.Text.Json;
using Train_project.classes;

namespace Train_project.Data
{
    public interface ITrainDataContext
    {
        public List<Train> LoadData();
        public bool SaveData(List<Train> data);
        

    }
}
