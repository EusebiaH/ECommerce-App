using AutoMapper;
using Internship.Business.PhysicalPersons.Commands.Create;
using Internship.Business.PhysicalPersons.Commands.Delete;
using Internship.Business.PhysicalPersons.Commands.Update;
using Internship.Business.PhysicalPersons.Queries.Filter;
using Internship.Business.PhysicalPersons.Queries.GetById;
using Internship.Controllers.PhysicalPersons.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.PhysicalPersons
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhysicalPersonController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public PhysicalPersonController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        // GET: api/<PhysicalPersonController>
        [HttpGet]
        public async Task<IActionResult> GetAllPhysicalPersons()
        {

            var physicalPersons = await _mediator.Send(new GetAllPhysicalPersonQuery());
            return Ok(physicalPersons);
        }

        // GET api/<PhysicalPersonController>/5
        [HttpGet("{id}")]
        public IActionResult GetPhysicalPersonId(int id)
        {
            var item = new GetByIdPhysicalPersonQuery(id);
            var physicalPerson = _mediator.Send(item);
            if (physicalPerson.Result == null)
                return NotFound();
            else
            {
                return Ok(physicalPerson.Result);
            }
        }

        // POST api/<PhysicalPersonController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PostPhysicalPersonRequest model)
        {
            var item = _mapper.Map<CreatePhysicalPersonCommand>(model);
            var newPhysicalPerson = await _mediator.Send(item);
            return Ok(newPhysicalPerson);

        }

        // PUT api/<PhysicalPersonController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] PutPhysicalPersonRequest model, int id)
        {
            var item = _mapper.Map<UpdatePhysicalPersonCommand>(model);
            item.Id = id;
            var updatePhysicalPerson = await _mediator.Send(item);
            return Ok(updatePhysicalPerson);

        }

        // DELETE api/<PhysicalPersonController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = new DeletePhysicalPersonCommand(id);
            var deletePhysicalPerson = await _mediator.Send(item);
            return Ok(deletePhysicalPerson);
        }
    }
}
