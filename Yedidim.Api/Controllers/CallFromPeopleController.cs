using Microsoft.AspNetCore.Mvc;
using Yedidim.Core.Entities;
using Yedidim.Core.Services;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallFromPeopleController : Controller
    {
        private readonly ICallFromPeopleService _CallFromPeopleService;
        public CallFromPeopleController(ICallFromPeopleService CallFromPeopleService)
        {
            _CallFromPeopleService = CallFromPeopleService;
        }

        // GET: TCallFromPeopleController
        [HttpGet]

        public ActionResult Get()
        {

            return Ok(_CallFromPeopleService.GetList());
        }

        // GET: CallFromPeopleController/Details/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var callFromPeople = _CallFromPeopleService.Get(id);
            if (callFromPeople == null)
            {
                return NotFound();
            }
            return Ok(callFromPeople);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public ActionResult Post([FromBody] CallFromPeople value)
        {
            var callFromPeople = _CallFromPeopleService.Get(value.Id);
            if (callFromPeople == null)
            {
                return Ok(_CallFromPeopleService.Add(callFromPeople));
            }
            return Conflict();
        }

        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CallFromPeople value)
        {
            var callFromPeople = _CallFromPeopleService.Get(value.Id);
            if (callFromPeople != null)
            {
                return Ok(_CallFromPeopleService.Update(value));
            }
            return Conflict();
        }
        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var callFromPeople = _CallFromPeopleService.Get(id);
            if (callFromPeople != null)
            {
                _CallFromPeopleService.Delete(callFromPeople);
            }
        }
    }
}
