using AutoMapper;
using Internship.Business.ProductCategories.Commands.Create;
using Internship.Business.ProductCategories.Queries;
using Internship.Controllers.ProductCategories.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.ProductCategories
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;

        private readonly IMediator _mediator;

        private EcomDbContext _dbContext;

        public ProductCategoryController(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _mediator = mediator;
        }

        // GET: api/<ProductCategoryController>
        [HttpGet]
        public async Task<IActionResult> GetAllProductCategories()
        {
            var ProdCat = await _mediator.Send(new GetAllProductCategoriesQuery());
            return Ok(ProdCat);
        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductCategory(int id)
        {
            var ProdCatFilterQuery = new GetProductCategoryFilterQuery(id);
            var response = await _mediator.Send(ProdCatFilterQuery);
            return Ok(response);
        }

        // POST api/<ProductCategoryController>
        [HttpPost]
        public async Task<IActionResult> Post(string prodCategory, bool active)
        {
                var productCategory = new PostProductCategoryCommand(prodCategory, active);
                var MedProdCat = _mediator.Send(productCategory);
                var result = _mapper.Map<PostProductCategoryResult>(MedProdCat.Result);

                return Ok(result);
        }

        // PUT api/<ProductCategoryController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductCategoryRequest request)
        {
            var a = _mediator.Send(request).Result;
            return Ok(a);
        }

        // DELETE api/<ProductCategoryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ProdCat = _dbContext.ProductCategorys.FirstOrDefault(x => x.Id == id);
            if (ProdCat == null)
                return NotFound();
            else
            {
                _dbContext.ProductCategorys.Remove(ProdCat);
                _dbContext.SaveChanges();
                return Ok("Product Category deleted");
            }

        }
    }
}
