using Microsoft.AspNetCore.Mvc;
using System;
using Train_project.classes;
using Train_project.Controllers;
using Train_project.services;
namespace UnitTest
{
    public class TestTrainController
    {
        [Fact]
        public void getAll_returnsOk()
        {
            //Arrange

            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Get();
            //Assert
            Assert.IsType<ActionResult<List<Train>>>(result);

        }
        [Fact]
        public void getById_returnsOk()
        {
            //Arrange
            int id = 1;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Get(id);
            //Assert
            Assert.IsType<Train>(result.Value);

        }
        [Fact]
        public void getById_returnsBadRequest()
        {
            //Arrange
            int id =-1;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Get(id);
            //Assert
            Assert.IsType<BadRequestResult>(result.Result);

        }
        [Fact]
        public void getById_returnsNotFound()
        {
            //Arrange
            int id = 2;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Get(id);
            //Assert
            Assert.IsType<NotFoundResult>(result.Result);

        }
        [Fact]
        public void Post_returnsBadRequest1()
        {
            //Arrange
            Train train = null;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Post( train);
            //Assert
            Assert.IsType<BadRequestResult>(result.Result);

        }
        [Fact]
        public void Post_returnsOk()
        {
            //Arrange
            Train train = new Train { TrainID = 1, TrainLine = 11, NumberOfCars = 2, Model = "mer", RegularRoute = "Jerusalem-TelAviv", TrainStatus = true, ServiceDate = new DateTime(2020, 04, 5) }; ;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Post(train);
            //Assert
            Assert.IsType<Train>(result.Value);

        }
        [Fact]
        public void Put_returnsOk()
        {
            //Arrange
            Train train = new Train { TrainID = 1, TrainLine = 11, NumberOfCars = 2, Model = "mer", RegularRoute = "Jerusalem-TelAviv", TrainStatus = true, ServiceDate = new DateTime(2020, 04, 5) };
            int id = 1;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Put(id, train);
            //Assert
            Assert.IsType<Train>(result.Value);

        }
        [Fact]
        public void Put_returnsNotFound()
        {
            //Arrange
            Train train = new Train { TrainID = 1, TrainLine = 11, NumberOfCars = 2, Model = "mer", RegularRoute = "Jerusalem-TelAviv", TrainStatus = true, ServiceDate = new DateTime(2020, 04, 5) };
            int id = 3;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Put(id, train);
            //Assert
            Assert.IsType<NotFoundResult>(result.Result);

        }
        [Fact]
        public void Delete_returnsOk()
        {
            //Arrange
            int id = 1;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Delete(id);
            //Assert
           // Assert.IsType<int>(result.Value);
            Assert.Equal(1, result.Value);


        }
        [Fact]
        public void Delete_returnsNotFound()
        {
            //Arrange
            int id = 3;
            //Act
            var trainController = new TrainController(new TrainService(new FakeTrainUnitTest()));
            var result = trainController.Delete(id);
            //Assert
            // Assert.IsType<int>(result.Value);
            Assert.IsType<NotFoundResult>(result.Result);


        }

    }
}