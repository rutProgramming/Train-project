using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Train_project.classes;
using Train_project.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private readonly TrainService _Trains;

        public TrainController(TrainService trains)
        {
            _Trains = trains;
        }


        // GET: api/<TrainController>
        [HttpGet]
        public ActionResult<List<Train>> Get()
        {
            List<Train>result= _Trains.Get();
            if (result==null) {return NotFound();}   
            return result;
        }

        // GET api/<TrainController>/5
        [HttpGet("{id}")]
        public ActionResult<Train> Get(int id)
        {
            if (id < 0) return BadRequest();
            Train train = _Trains.GetById(id);
            if (train == null)
            {
                return NotFound();
            }
            return train;
        }

        // POST api/<TrainController>
        [HttpPost]
        public ActionResult<Train> Post([FromBody] Train train)
        {
            if (train == null) return BadRequest();
            _Trains.AddTrain(train);
            return train;

        }

        // PUT api/<TrainController>/5
        [HttpPut("{id}")]
        public ActionResult<Train> Put(int id, [FromBody] Train train)
        {
            bool success = _Trains.UpdateTrain(id, train);
            if (success)
            {
                return train;
            }
            return NotFound();
        }

        // DELETE api/<TrainController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            bool success = _Trains.DeleteTrain(id);
            if (success)
            {
                return id;
            }
            return NotFound();
        }
    }
}
