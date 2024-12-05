using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yedidim.Core.Services;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : Controller
    {
        private readonly IVolunteerService _VolunteerService;
        public VolunteerController(IVolunteerService VolunteerService)
        {
            _VolunteerService = VolunteerService;
        }
        // GET: VolunteerController
        [HttpGet]

        public ActionResult Get()
        {

            return Ok(_VolunteerService.GetList());
        }

        // GET: CallFromPeopleController/Details/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var v = _VolunteerService.Get(id);
            if (v == null)
            {
                return NotFound();
            }
            return Ok(v);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public ActionResult Post([FromBody] Volunteer value)
        {
            var v = _VolunteerService.Get(value.Id);
            if (v == null)
            {
                return Ok(_VolunteerService.Add(v));
            }
            return Conflict();
        }

        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Volunteer value)
        {
            var v = _VolunteerService.Get(value.Id);
            if (v != null)
            {
                return Ok(_VolunteerService.Update(value));
            }
            return Conflict();
        }
        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var callFromPeople = _VolunteerService.Get(id);
            if (callFromPeople != null)
            {
                _VolunteerService.Delete(callFromPeople);
            }
        }
    }
}


