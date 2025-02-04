using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yedidim.Api.Models;
using Yedidim.Core.DTOs;
using Yedidim.Core.Services;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class VolunteerController : Controller
    {
        private readonly IVolunteerService _VolunteerService;
        private readonly IMapper _mapper;

        public VolunteerController(IVolunteerService VolunteerService, IMapper mapper)
        {
            _VolunteerService = VolunteerService;
            _mapper = mapper;
        }
        // GET: VolunteerController
        [HttpGet]

        public async Task<ActionResult> Get()
        {

            var volunteer = await _VolunteerService.GetList();
            var volunteerDto = _mapper.Map<IEnumerable<VolunteerDto>>(volunteer);
            return Ok(volunteerDto);
        }

        // GET: CallFromPeopleController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var v = await _VolunteerService.Get(id);
            if (v == null)
            {
                return NotFound();
            }
            var volunteerDto = _mapper.Map<VolunteerDto>(v);
            return Ok(volunteerDto);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public async Task<ActionResult> Post([FromBody] VolunteerModel value)
        {
            var volunteer = _mapper.Map<Volunteer>(value);
            var v = await _VolunteerService.Add(volunteer);
            var volunteerDto = _mapper.Map<VolunteerDto>(v);
            return Ok(volunteerDto);
        }

        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] VolunteerModel value)
        {
            var volunteer = _mapper.Map<Volunteer>(value);
            var v = await _VolunteerService.Update(id, volunteer);

            var volunteerDto = _mapper.Map<VolunteerDto>(v);

            return Ok(volunteerDto);
        }
        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _VolunteerService.Delete(id);
        }
    }
}


