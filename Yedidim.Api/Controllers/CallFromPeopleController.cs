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
        public async Task<ActionResult> Get()
        {

            var calls = await _CallFromPeopleService.GetList();
            var callsDto = _mapper.Map<IEnumerable<CallsDto>>(calls);
            return Ok(callsDto);
        }

        // GET: CallFromPeopleController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var c = await _CallFromPeopleService.Get(id);
            if (c == null)
            {
                return NotFound();
            }
            var callsDto = _mapper.Map<CallsDto>(c);
            return Ok(callsDto);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public async Task<ActionResult> Post([FromBody] CallsPostModel value)
        {
            var call = _mapper.Map<CallFromPeople>(value);
            var call2 = await _CallFromPeopleService.Add(call);
            var callDto = _mapper.Map<CallsDto>(call2);
            return Ok(callDto);
        }

        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CallsPostModel value)
        {
            var c = _mapper.Map<CallFromPeople>(value);

            var call = await _CallFromPeopleService.Update(id, c);

            var callDto = _mapper.Map<CallsDto>(call);

            return Ok(callDto);
        }
        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _CallFromPeopleService.Delete(id);

        }
    }
}
