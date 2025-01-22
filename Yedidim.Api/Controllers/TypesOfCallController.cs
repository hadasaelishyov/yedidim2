using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Yedidim.Api.Models;
using Yedidim.Core.DTOs;
using Yedidim.Core.Services;

namespace Yedidim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesOfCallController : Controller
    {
        private readonly ITypesOfCallService _TypesOfCallService;
        private readonly IMapper _mapper;

        public TypesOfCallController(ITypesOfCallService TypesOfCallService, IMapper mapper)
        {
            _TypesOfCallService = TypesOfCallService;
            _mapper = mapper;

        }
        // GET: TCallFromPeopleController
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            var type = await _TypesOfCallService.GetList();
            var typesDto = _mapper.Map<IEnumerable<TypesOfCallDto>>(type);
            return Ok(typesDto);

        }

        // GET: CallFromPeopleController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var t = await _TypesOfCallService.Get(id);
            if (t == null)
            {
                return NotFound();
            }
            var typeDto = _mapper.Map<TypesOfCallDto>(t);
            return Ok(typeDto);
        }
        [HttpPost]
        // POST: CallFromPeopleController/Create
        public async Task<ActionResult> Post([FromBody] TypesOfCallModel value)
        {
            var t = _mapper.Map<TypesOfCall>(value);
            var type = await _TypesOfCallService.Add(t);
            var typeDto = _mapper.Map<TypesOfCallDto>(type);
            return Ok(typeDto);
        }

        // PUT api/<CallFromPeopleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TypesOfCallModel value)
        {
            var t = _mapper.Map<TypesOfCall>(value);

            var type = await _TypesOfCallService.Update(id, t);

            var typeDto = _mapper.Map<TypesOfCallDto>(type);

            return Ok(typeDto);
        }

        // DELETE api/<CallFromPeopleController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _TypesOfCallService.Delete(id);
        }
    }
}

