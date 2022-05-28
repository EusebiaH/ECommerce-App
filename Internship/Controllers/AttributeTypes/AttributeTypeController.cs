using AutoMapper;
using Internship.Business.Attributes.Queries.GetById;
using Internship.Business.AttributeTypes.Commands.Create;
using Internship.Business.AttributeTypes.Commands.Queries.GetAllAttributeTypes;
using Internship.Business.AttributeTypes.Commands.Update;
using Internship.Controllers.AttributeTypes.Models;
using Internship.Business.AttributeTypes.Commands.Delete;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Internship.Business.AttributeTypes.Commands.Queries.GetAttributeTypeById;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.AttributeTypes
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AttributeTypeController : ControllerBase
    {
            private EcomDbContext _dbContext;
            private readonly IMapper _mapper;
            private readonly IMediator _mediatR;
            public AttributeTypeController(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
            {
                _dbContext = dbContext;
                _mapper = mapper;
                _mediatR = mediator;
            }
            // GET: api/<AttributeTypeController>
            [HttpGet]
        public async Task<IActionResult> GetAllAttributeTypes()
        {
            var result = await _mediatR.Send(new GetAllAttributeTypesQuery());
            return Ok(result);
        }

        // GET api/<AttributeTypeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttributeTypeById(int id)
        {
            var result = await _mediatR.Send(new GetAttributeTypeByIdQuery(id));
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<AttributeTypeController>
        [HttpPost]
        public async Task<string> CreateNewAttributeType(CreateAttributeType createAttributeType)
        {
            var createAttributeCommand = _mapper.Map<CreateNewAttributeTypeCommand>(createAttributeType);
            var result = await _mediatR.Send(createAttributeCommand);
            return result;
        }

        // PUT api/<AttributeTypeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAttributeType(int id, [FromBody] UpdateAttributeType updateAttributeType)
        {
            var result = await _mediatR.Send(new UpdateAttributeTypeCommand(id, updateAttributeType));
            return Ok(result);
        }

        // DELETE api/<AttributeTypeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAttributeType(int id)
        {
            var result = await _mediatR.Send(new DeleteAttributeTypeCommand(id));
            return Ok(result);
        }
    }
}
