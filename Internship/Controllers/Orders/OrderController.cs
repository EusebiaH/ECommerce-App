using AutoMapper;
using Internship.Business.Orders.Commands.Create;
using Internship.Business.Orders.Commands.Delete;
using Internship.Business.Orders.Commands.Update;
using Internship.Business.Orders.Queries;
using Internship.Business.Products.Commands.Delete;
using Internship.Controllers.Orders.Pagination;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Orders
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;


        public OrderController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }


        [HttpGet("{page}")]
        public IActionResult GetOrderPage(int page, double objectsOnPage)
        {
            var item = new GetByPageQuery(page, objectsOnPage);
            var order=_mediator.Send(item);

            if (order.Result==null)
                return NotFound();
            else 
                return Ok(order.Result);
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var order = new GetAllOrdersQuery();
            var orders = _mediator.Send(order).Result;
            if (orders == null)
                return NotFound();
            else
                return Ok(orders);  
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult  GetById(int id)
        {
            var order = new GetAllOrdersByIdQuery(id);
            var order1 = _mediator.Send(order).Result;
            if (order1 == null)
                return NotFound();
            else
                return Ok(order1); 


            
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post(PostOrderRequest order)
        {
            var orderRequest = _mapper.Map<PostOrderCommand>(order);
            var orderResult = _mediator.Send(orderRequest).Result;
            return Ok(orderResult); 

        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public IActionResult UpdateById(UpdateOrderRequest order)
        {
            var orderRequest = _mapper.Map<UpdateOrderCommand>(order); 
            var orderResult = _mediator.Send(orderRequest).Result;
            if (orderResult == null)
                return NotFound();
            else
                return Ok(orderResult);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var order = new DeleteOrderCommand(id);
            var orderResult = _mediator.Send(order).Result;
            if (orderResult == null)
                return NotFound();
            else
                return Ok("Item Deleted"); 
        }
    }
}
