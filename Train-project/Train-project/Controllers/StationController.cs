using Microsoft.AspNetCore.Mvc;
using Train_project.classes;
using Train_project.entities;
using Train_project.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly StationService _Stations = new StationService();
        // GET: api/<StationController>
        [HttpGet]
        public ActionResult<List<Station>> Get()
        {
            return _Stations.Get();
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public ActionResult<Station> Get(int id)
        {
            if (id < 0) return BadRequest();
            Station station = _Stations.GetById(id);
            if (station == null)
            {
                return NotFound();
            }
            return station;
        }

        // POST api/<StationController>
        [HttpPost]
        public ActionResult<Station> Post([FromBody] Station station)
        {
            if (station == null) return BadRequest();
            bool valid=_Stations.AddStation(station);
            if (!valid) {return BadRequest();}
            return station;
            
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public ActionResult<Station> Put(int id, [FromBody] Station station)
        {
            bool success = _Stations.UpdateStation(id, station);
            if (success)
            {
                return station;
            }
            return NotFound();
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            bool success = _Stations.DeleteStation(id);
            if (success)
            {
                return id;
            }
            return NotFound();
        }
    }
}
