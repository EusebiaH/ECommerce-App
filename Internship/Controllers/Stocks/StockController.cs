using AutoMapper;
using Internship.Business.Stocks.Commands.Create;
using Internship.Business.Stocks.Commands.Delete;
using Internship.Business.Stocks.Commands.Update;
using Internship.Business.Stocks.Queries.Filter;
using Internship.Business.Stocks.Queries.GetById;
using Internship.Controllers.Stocks.Models;
using Internship.Controllers.Stocks.ModelsStock;
using Internship.Controllers.Stocks.Pagination;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Stocks
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly EcomDbContext _context;
       
        public StockController(IMediator mediator, IMapper mapper, EcomDbContext context)
        {
            _mapper = mapper;
            _mediator = mediator;
            _context = context;
        }
        // GET: api/<StockController>
        [HttpGet]
        public async Task<IActionResult> GetAllStocks()
        {

            var stocks = await _mediator.Send(new GetAllStockQuery());
            return Ok(stocks);
        }

        // GetByPage


        [HttpGet("{page}")]
        public IActionResult GetStockPage(int page, double objectsOnPage)
        {

            var item = new GetByPageQuery(page, objectsOnPage);
            var stock = _mediator.Send(item);
            if (stock.Result == null)
                return NotFound();
            else
            {
                return Ok(stock.Result);
            }
        }

        // GET api/<StockController>/5
        [HttpGet("{id}")]
        public IActionResult GetStockId(int id)
        {
            var item = new GetStockByIdQuery(id);
            var stock = _mediator.Send(item);
            if (stock.Result == null)
                return NotFound();
            else
            {
                return Ok(stock.Result);
            }
        }
        // GET api/<StockController>/5
        [HttpGet("{id}")]
        public IActionResult GetStockByProductId(int id)
        {
            var item = new GetByIdProductQuery(id);
            var stock = _mediator.Send(item);
            if (stock.Result == null)
                return NotFound();
            else
            {
               
                return Ok(stock.Result);
            }
        }

        // POST api/<StockController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StockRequest model)
        {
            var item = _mapper.Map<CreateStockCommand>(model);
            var newStock = await _mediator.Send(item);
            return Ok(newStock);

        }


        // PUT api/<StockController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StockRequest model, int Id)
        {
            var item = _mapper.Map<UpdateStockCommand>(model);
            item.Id = Id;
            var updateStock = await _mediator.Send(item);
            return Ok(updateStock);

        }

        // DELETE api/<StockController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = new DeleteStockCommand(id);
            var deleteStock = await _mediator.Send(item);
            return Ok(deleteStock);
        }
    }
}
