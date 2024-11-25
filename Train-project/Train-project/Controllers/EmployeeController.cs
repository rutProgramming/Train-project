using Microsoft.AspNetCore.Mvc;
using Train_project.classes;
using Train_project.services;
using static System.Collections.Specialized.BitVector32;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _Employees = new EmployeeService();

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return _Employees.Get();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            if (id < 0) return BadRequest();
            Employee employee = _Employees.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            if (employee == null)
                return BadRequest();
            bool valid=_Employees.AddEmployee(employee);
            if (!valid)
                return BadRequest();
            return employee;

        }


        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            bool success = _Employees.UpdateEmployee(id, employee);
            if (success)
            {
                return  employee;
            }
            return NotFound();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            bool success = _Employees.DeleteEmployee(id);
            if (success)
            {
                return id;
            }
            return NotFound();
        }
    }
}
