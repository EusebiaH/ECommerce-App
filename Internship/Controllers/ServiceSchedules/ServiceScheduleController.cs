using AutoMapper;
using Internship.Business.ServiceSchedules.Commands;
using Internship.Business.ServiceSchedules.Queries;
using Internship.Controllers.ServiceSchedules.ServiceScheduleModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Controllers.ServiceSchedules
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceScheduleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ServiceScheduleController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllServiceSchedules()
        {
            var result = await _mediator.Send(new GetAllServiceSchedulesQuery());
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetServiceScheduleById(int id)
        {
            var request = new GetServiceScheduleByIdQuery(id);
            var result = await _mediator.Send(request);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(PostServiceScheduleRequest request)
        {
            var serviceSchedule = _mapper.Map<PostServiceScheduleCommand>(request);
            return Ok(await _mediator.Send(serviceSchedule));
        }
        [HttpPut]
        public async Task<IActionResult> Put(UpdateServiceScheduleByIdRequest request)
        {
            var result = await _mediator.Send(_mapper.Map<UpdateServiceScheduleCommand>(request));
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = new ServiceScheduleDeleteCommand(id);
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
