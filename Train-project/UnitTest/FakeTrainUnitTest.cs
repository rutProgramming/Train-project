using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_project.classes;
using Train_project.Data;

namespace UnitTest
{
    internal class FakeTrainUnitTest:ITrainDataContext
    {
        public List<Train> LoadData()
        {
            List<Train>  trains = new List<Train> { new Train(1, 12, 2, true, "Jerusalem-TelAviv", "mer", new DateTime(2020, 04, 5)) };
            return trains;
        }
        public bool SaveData(List<Train> trains) { return true; }
    }
}
