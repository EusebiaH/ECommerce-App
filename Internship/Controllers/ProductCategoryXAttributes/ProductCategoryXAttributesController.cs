using AutoMapper;
using Internship.Business.ProductCategoryXAttributes.Commands.Create;
using Internship.Business.ProductCategoryXAttributes.Commands.Update;
using Internship.Business.ProductCategoryXAttributes.Queries.Filter;
using Internship.Business.ProductCategoryXAttributes.Queries.GetById;
using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.ProductCategoryXAttributes
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductCategoryXAttributesController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IMediator _mediator;

        private EcomDbContext _dbContext;
        public ProductCategoryXAttributesController(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _mediator = mediator;
        }
        
        // GET: api/<ProductCategoryXAttributesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = new GetAllProductCategoryXAttributeQuery();
            var ProdCatXAttribute=_mediator.Send(request).Result;
            if(ProdCatXAttribute == null)
                return NotFound();
            else
                return Ok(ProdCatXAttribute);
        }

        // GET api/<ProductCategoryXAttributesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductCategoryXAttribute(int id)
        {
            var ProdCatXAttQuery = new GetProductCategoryXAttributeByIdQuery(id);
            var response = await _mediator.Send(ProdCatXAttQuery);

            return Ok(response);
        }

        // POST api/<ProductCategoryXAttributesController>
        [HttpPost]
        public async Task<IActionResult> Post(int productCategoryId, int attributeId)
        {
            var prodCatXAttribute = new PostProductCategoryXAttributeCommand(productCategoryId, attributeId);
            var result = _mediator.Send(prodCatXAttribute).Result;
            

            return Ok(result);
        }

        // PUT api/<ProductCategoryXAttributesController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductCategoryXAttributeCommand request)
        {
            var UpdProdCatXAtt = _mediator.Send(request).Result;
            return Ok(UpdProdCatXAtt);
        }

        // DELETE api/<ProductCategoryXAttributesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ProdCatXAttribute = _dbContext.ProductCategoryXAttributes.FirstOrDefault(x => x.Id == id);
            if (ProdCatXAttribute == null)
                return NotFound();
            else
            {
                _dbContext.ProductCategoryXAttributes.Remove(ProdCatXAttribute);
                _dbContext.SaveChanges();
                return Ok("ProductCategoryXAttributes deleted");
            }
        }
    }
}
