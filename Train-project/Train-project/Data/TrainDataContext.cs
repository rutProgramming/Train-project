using System.Text.Json;
using Train_project.classes;
namespace Train_project.Data
{
    public class TrainDataContext:ITrainDataContext
    {
        public List<Train> LoadData()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "TrainData.json");
                string jsonString = File.ReadAllText(path);

                var AllTrains = JsonSerializer.Deserialize<List<Train>>(jsonString);
                if (AllTrains == null) { return null; }

                return AllTrains;
            }
            catch
            {
                return null;
            }
        }
        public bool SaveData(List<Train> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "TrainData.json");
                string jsonString = JsonSerializer.Serialize<List<Train>>(data);
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }

    }
}

