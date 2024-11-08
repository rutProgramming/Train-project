using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Train_project.classes;
using Train_project.entities;
using Train_project.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainRouteController : ControllerBase
    {
        private readonly TrainRouteService _TrainRoutes = new TrainRouteService();
        valid valid= new valid();
        // GET: api/<TrainRouteController>
        [HttpGet]
        public ActionResult<List<TrainRoute>> Get()
        {
           return _TrainRoutes.Get();
        }

        // GET api/<TrainRouteController>/5
        [HttpGet("{id}")]
        public ActionResult<TrainRoute> Get(int id)
        {
            if (id < 0) return BadRequest();
            TrainRoute trainRoute = _TrainRoutes.GetById(id);
            if (trainRoute == null)
            {
                return NotFound();
            }
            return trainRoute;
        }

        // POST api/<TrainRouteController>
        [HttpPost]
        public ActionResult<TrainRoute> Post([FromBody] TrainRoute trainRoute)
        {
            if (trainRoute == null) return BadRequest();
            bool valid = _TrainRoutes.AddTrainRoute(trainRoute);
            if (!valid) return BadRequest();
            return trainRoute;
        }

        // PUT api/<TrainRouteController>/5
        [HttpPut("{id}")]
        public ActionResult<TrainRoute> Put(int id, [FromBody] TrainRoute trainRoute)
        {
            bool success = _TrainRoutes.UpdateTrainRoute(id, trainRoute);
            if (success)
            {
                return trainRoute;
            }
            return NotFound();
        }

        // DELETE api/<TrainRouteController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            bool success = _TrainRoutes.DeleteTrainRoute(id);
            if (success)
            {
                return id;
            }
            return NotFound();
        }
    }
}
