using AutoMapper;
using Internship.Business.Statuses.Commands.Create;
using Internship.Business.Statuses.Commands.Update;
using Internship.Business.Statuses.Queries.GetById;
using Internship.Data;
using Internship.Data.Statuses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Statuses
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatusController : ControllerBase
    {

        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public StatusController(EcomDbContext dbContext, IMediator mediator, IMapper mapper)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: api/<StatusController>
        [HttpGet]
        public IActionResult GetAllStatuses()
        {
            var getStatuses = _dbContext.Statuses;
            var getStatusesResult = _mapper.Map<List<GetStatusResult>>(getStatuses);
            return Ok(getStatusesResult);
        }

        // GET api/<StatusController>/5
        [HttpGet("{id}")]
        public IActionResult GetStatusById(int id)
        {
            var x = new GetStatusByIdQuery(id);
            return Ok(_mediator.Send(x).Result);
        }

        // POST api/<StatusController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StatusRequest request)
        {
           var statusRequest = _mapper.Map<CreateStatusCommand>(request);
           var handle = await _mediator.Send(statusRequest);
            return Ok(handle);
        }

        // PUT api/<StatusController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] UpdateStatusRequest request)
        {
            var statusRequest=_mapper.Map<UpdateStatusCommand>(request);
            var handle=await _mediator.Send(statusRequest);
            return Ok(handle);
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}


