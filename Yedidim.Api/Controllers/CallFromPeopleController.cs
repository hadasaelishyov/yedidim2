using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Yedidim.Api.Models;
using Yedidim.Core.DTOs;
using Yedidim.Core.Entities;
using Yedidim.Core.Services;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallFromPeopleController : Controller
    {
        private readonly ICallFromPeopleService _CallFromPeopleService;
        private readonly IMapper _mapper;

        public CallFromPeopleController(ICallFromPeopleService CallFromPeopleService, IMapper mapper)
        {
            _CallFromPeopleService = CallFromPeopleService;
            _mapper = mapper;
        }

        // GET: TCallFromPeopleController
        [HttpGet]

        public ActionResult Get()
        {


            var callsDto = _mapper.Map<IEnumerable<CallsDto>>(_CallFromPeopleService.GetList());
            //foreach (var student in students)
            //{
            //    studentsDto.Add(_mapping.MapStudentToDto(student));
            //}
            return Ok(callsDto);
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
            var callsDto = _mapper.Map<CallsDto>(callFromPeople);
            return Ok(callsDto);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public ActionResult Post([FromBody] CallsPostModel value)
        {
            //var callFromPeople = _CallFromPeopleService.Get(value.Id);
            //if (callFromPeople == null)
            //{
            //    return Ok(_CallFromPeopleService.Add(callFromPeople));
            //}
            //return Conflict();
            var calls = _mapper.Map<CallFromPeople>(value);
            return Ok(_CallFromPeopleService.Add(calls));
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
