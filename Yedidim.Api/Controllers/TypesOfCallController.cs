using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yedidim.Core.Services;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesOfCallController : Controller
    {
        private readonly ITypesOfCallService _TypesOfCallService;
        public TypesOfCallController(ITypesOfCallService TypesOfCallService)
        {
            _TypesOfCallService = TypesOfCallService;
        }
        // GET: TCallFromPeopleController
        [HttpGet]

        public ActionResult Get()
        {

            return Ok(_TypesOfCallService.GetList());
        }

        // GET: CallFromPeopleController/Details/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var t = _TypesOfCallService.Get(id);
            if (t == null)
            {
                return NotFound();
            }
            return Ok(t);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public ActionResult Post([FromBody] TypesOfCall value)
        {
            var t = _TypesOfCallService.Get(value.Id);
            if (t == null)
            {
                return Ok(_TypesOfCallService.Add(t));
            }
            return Conflict();
        }

        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TypesOfCall value)
        {
            var t = _TypesOfCallService.Get(value.Id);
            if (t != null)
            {
                return Ok(_TypesOfCallService.Update(value));
            }
            return Conflict();
        }
        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var t = _TypesOfCallService.Get(id);
            if (t != null)
            {
                _TypesOfCallService.Delete(t);
            }
        }
    }
}

