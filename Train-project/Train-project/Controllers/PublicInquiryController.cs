using Microsoft.AspNetCore.Mvc;
using Train_project.classes;
using Train_project.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Train_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicInquiryController : ControllerBase
    {
        private readonly PublicInquiryService _PublicInquiries = new PublicInquiryService();
        // GET: api/<PublicInquiryController>
        [HttpGet]
        public ActionResult<List<PublicInquiry>> Get()
        {
            return _PublicInquiries.Get();
        }

        // GET api/<PublicInquiryController>/5
        [HttpGet("{id}")]
        public ActionResult<PublicInquiry> Get(int id)
        {
            if (id < 0) return BadRequest();
            PublicInquiry publicInquiry = _PublicInquiries.GetById(id);
            if (publicInquiry == null)
            {
                return NotFound();
            }
            return publicInquiry;
        }

        // POST api/<PublicInquiryController>
        [HttpPost]
        public ActionResult<PublicInquiry> Post([FromBody] PublicInquiry publicInquiry)
        {
            if (publicInquiry == null)
                return BadRequest();
             bool valid= _PublicInquiries.AddPublicInquiry(publicInquiry);
             if (!valid)
                return BadRequest();
            return publicInquiry;

        }

        // PUT api/<PublicInquiryController>/5
        [HttpPut("{id}")]
        public ActionResult<PublicInquiry> Put(int id, [FromBody] PublicInquiry publicInquiry)
        {
            bool success = _PublicInquiries.UpdatePublicInquiry(id, publicInquiry);
            if (success)
            {
                return publicInquiry;
            }
            return NotFound();
        }

        // DELETE api/<PublicInquiryController>/5
        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            bool success = _PublicInquiries.DeletePublicInquiry(id);
            if (success)
            {
                return id;
            }
            return NotFound();
        }
    }
}
