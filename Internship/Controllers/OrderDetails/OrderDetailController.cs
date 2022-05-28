using AutoMapper;
using Internship.Business.OrderDetails.Commands.Create;
using Internship.Business.OrderDetails.Commands.Delete;
using Internship.Business.OrderDetails.Queries;
using Internship.Business.Orders.Commands.Create;
using Internship.Controllers.OrderDetails.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.OrderDetails
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public OrderDetailController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostOrderDetailRequest request)
        {
            var orderDetail = _mapper.Map<CreateOrderDetailCommand>(request);
            var result = await _mediator.Send(orderDetail);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrderDetails()
        {
            return  Ok(await _mediator.Send(new GetAllOrderDetailsQuery()));
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetOrderDetailById(int id)
        {
            var orderDetail = await _mediator.Send(new GetOrderDetailByIdQuery(id));
            return Ok(orderDetail);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(_mediator.Send(new DeleteOrderDetailCommand(id)));
        }

    }
}
