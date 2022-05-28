using AutoMapper;
using Internship.Business.Manufacturers.Commands.Create;
using Internship.Business.Manufacturers.Commands.Delete;
using Internship.Business.Manufacturers.Commands.Update;
using Internship.Business.Manufacturers.Queries.Filter;
using Internship.Business.Manufacturers.Queries.GetById;
using Internship.Controllers.Manufacturers.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Manufacturers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ManufacturerController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        // GET: api/<ManufacturerController>
        [HttpGet]
        public async Task<IActionResult> GetAllManufacturers()
        {

            var manufacturers = await _mediator.Send(new GetAllManufacturerQuery());
            return Ok(manufacturers);
        }

        // GET api/<ManufacturerController>/5
        [HttpGet("{id}")]
        public IActionResult GetManufacturerId(int id)
        {
            var item = new GetManufacturerByIdQuery(id);
            var manufacturer = _mediator.Send(item);
            if (manufacturer.Result == null)
                return NotFound();
            else
            {
                return Ok(manufacturer.Result);
            }
        }

        // POST api/<ManufacturerController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PostManufacturerRequest model)
        {
            var item = _mapper.Map<CreateManufacturerCommand>(model);
            var newManufacturer = await _mediator.Send(item);
            return Ok(newManufacturer);

        }


        // PUT api/<ManufacturerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] PutManufacturerRequest model, int id)
        {
            var item = _mapper.Map<UpdateManufacturerCommand>(model);
            item.Id = id;
            var updateManufacturer = await _mediator.Send(item);
            return Ok(updateManufacturer);

        }

        // DELETE api/<ManufacturerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = new DeleteManufacturerCommand(id);
            var deleteManufacturer = await _mediator.Send(item);
            return Ok(deleteManufacturer);
        }
    }
}
