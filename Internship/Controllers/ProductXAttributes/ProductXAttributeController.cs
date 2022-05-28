using AutoMapper;
using Internship.Business.ProductXAttributes.Commands.Create;
using Internship.Business.ProductXAttributes.Commands.Update;
using Internship.Business.ProductXAttributes.Delete;
using Internship.Business.ProductXAttributes.Queries.Filter;
using Internship.Business.ProductXAttributes.Queries.GetById;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Controllers.ProductTypes.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductXAttributeController : ControllerBase
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ProductXAttributeController(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        // GET: api/<ProductXAttributeController>
        [HttpGet]
        public async Task<IActionResult> GetAllProdXAtr()
        {
            var prodXAtt = new GetAllProductXAttributeQuery();
            var result = _mediator.Send(prodXAtt).Result;
            return Ok(result);
        }

        // GET api/<ProductXAttributeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdXAtrById(int id)
        {
            var request = new GetByIdProductXAttributeQuery(id);
            var result = _mediator.Send(request).Result;
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        // POST api/<ProductXAttributeController>
        [HttpPost]
        public async Task<IActionResult> PostProdXAttr([FromBody] CreateProductXAttributeRequest request)
        {
            var productXAtrRequest = _mapper.Map<CreateProductXAttributeCommand>(request);
            var productResult = _mediator.Send(productXAtrRequest);
            return Ok(productResult);
        }

        // PUT api/<ProductXAttributeController>/5
        [HttpPut]
        public async Task<IActionResult> UpdateById(UpdateProductXAttributeRequest request)
        {
            var productRequest = _mapper.Map<UpdateProductXAttributeCommand>(request);
            var result = _mediator.Send(productRequest).Result;
            if (result == null)
                return NotFound();
            else
                return Ok(result);

        }

        // DELETE api/<ProductXAttributeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = new DeleteProductXAttributeCommand(id);
            var result = _mediator.Send(request).Result;
            if (result == null)
                return NotFound();
            else
                return Ok("Item Deleted");
        }
    }
}
