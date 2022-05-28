using AutoMapper;
using Internship.Business.LegalPersons.Commands.Create;
using Internship.Business.LegalPersons.Commands.Delete;
using Internship.Business.LegalPersons.Commands.Queries;
using Internship.Business.LegalPersons.Commands.Update;
using Internship.Controllers.LegalPersons.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.LegalPersons
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LegalPersonController : ControllerBase
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public LegalPersonController(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }



        [HttpPost]
        public async Task<IActionResult> PostLegalPerson(PostLegalPersonRequest request)
        {
            var legalPerson = _mapper.Map<CreateLegalPersonCommand>(request);
            var result = await _mediator.Send(legalPerson);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllLegalPersons()
        {
            var legalPersons = await _dbContext.LegalPersons.ToListAsync();
            return Ok(legalPersons);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetLegalPersonById(int id)
        {
            var legalPerson = new GetLegalPersonByIdQuery(id);
            var result = await _mediator.Send(legalPerson);
            return Ok(result);
        }
        [HttpPut("id")]
        public async Task<IActionResult> UpdateLegalPerson(UpdateLegalPersonRequest request, int id)
        {
            var person = _mapper.Map<UpdateLegalPersonCommand>(request);
            person.Id = id;
            var result = await _mediator.Send(person);
            return Ok(result);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteLegalPerson(int id)
        {
            var request = new DeleteLegalPersonCommand(id);
            var result = await _mediator.Send(request);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
    }
}
