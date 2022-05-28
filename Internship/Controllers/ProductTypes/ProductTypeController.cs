using AutoMapper;
using Internship.Business.ProductTypes.Commands.Create;
using Internship.Business.ProductTypes.Commands.Delete;
using Internship.Business.ProductTypes.Commands.Update;
using Internship.Business.ProductTypes.Queries.Filter;
using Internship.Business.ProductTypes.Queries.GetByld;
using Internship.Controllers.ProductTypes.Mapping;
using Internship.Controllers.ProductTypes.Models;
using Internship.Data;
using Internship.Data.ProductsType;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.ProductTypes
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private EcomDbContext _dbContext;

        public ProductTypeController(EcomDbContext ecomDbContext, IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
            _dbContext = ecomDbContext;
        }
        // GET: api/<ProductTypeController>
        [HttpGet]
        public async Task<IActionResult> GetAllProductType()
        {
            var productType = await _mediator.Send(new FIlterProductTypeQuery());
            return Ok(productType);
        }

        // GET api/<ProductTypeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductTypeId(int id)
        {
            var item = new GetProductTypeByIdQuery(id);
            var productType = _mediator.Send(item);
            if (productType.Result == null)
                return NotFound();
            else
            {
                return Ok(productType.Result);
            }
        }

        // POST api/<ProductTypeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductTypeCommand request)
        {

            return Ok(_mediator.Send(request).Result);


        }

        // PUT api/<ProductTypeController>/5
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductTypeCommand model)
        {
            var update = _mediator.Send(model).Result;
            return Ok(update);

        }

        // DELETE api/<ProductTypeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = new DeleteProductTypeCommand(id);
            var deleteProductType = await _mediator.Send(item);
            return Ok(deleteProductType);
        }
    }
}
