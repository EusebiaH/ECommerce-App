using AutoMapper;
using Internship.Business.Attributes.Commands.Create;
using Internship.Business.Attributes.Commands.Update;
using Internship.Business.Attributes.Queries.GetById;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Attributes
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IMediator _mediator;

        private EcomDbContext _dbContext;
        public AttributeController(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _mediator = mediator;
        }



        // GET: api/<AttributeController>
        [HttpGet]
        public async Task<IActionResult> GetAllAtributes()

        {
            var atributeeList = _dbContext.Attributes;
            var atributeListResult = _mapper.Map<List<GetAttributes>>(atributeeList);
            return Ok(atributeListResult);
        }

        // GET api/<AttributeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAttribute(int id)
        {
            var AttQuery = new GetAttributeByIdQuery(id);
            var response = await _mediator.Send(AttQuery);

            return Ok(response);
        }

        // POST api/<AttributeController>
        [HttpPost]
        public async Task<IActionResult> Post(string attributeName, bool active,int attributeTypeId)
        {
            var attribute = new PostAttributeCommand(attributeName, active, attributeTypeId);
            var attributeMed=_mediator.Send(attribute).Result;
            var result=_mapper.Map<PostAttributeResult>(attributeMed);

            return Ok(result);
        }

        // PUT api/<AttributeController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateAttributeCommand request)
        {
            var att=_mediator.Send(request).Result;
            return Ok(att);
        }

        // DELETE api/<AttributeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Att = _dbContext.Attributes.FirstOrDefault(x => x.Id == id);
            if (Att == null)
                return NotFound();
            else
            {
                _dbContext.Attributes.Remove(Att);
                _dbContext.SaveChanges();
                return Ok("Attribute deleted");
            }
        }
    }
}
