using AutoMapper;
using Internship.Business.Products.Commands;
using Internship.Business.Products.Commands.Delete;
using Internship.Business.Products.Commands.Update;
using Internship.Business.Products.Queries;
using Internship.Controllers.Products.Models;
using Internship.Controllers.Products.Pagination;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Controllers.Products
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
        //GetProductByPage
        [HttpGet("{page}")]
        public async Task<IActionResult> GetProductPage(int page, double objectOnPage)
        {
            var item = new ProductGetByPageQuery(page, objectOnPage);
            var product = _mediator.Send(item);
            if (product.Result == null)
                return NotFound();
            else
                return Ok(product.Result);
        }
        // GET: ProductController
        [HttpPost]
        public async Task<IActionResult> Post(PostProductRequest request)
        {
            var productRequest = _mapper.Map<PostProductCommand>(request);
            var productResult =await _mediator.Send(productRequest);
            return Ok(productResult);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var request = new GetProductByIdQuery(id);
            var result = await _mediator.Send(request);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var request = new GetAllProductsQuery();
            var products = await _mediator.Send(request);
            if (products == null)
                return NotFound();
            else
                return Ok(products);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateById(UpdateProductRequest request)
        {
            var productRequest = _mapper.Map<UpdateProductCommand>(request);
            var result = await _mediator.Send(productRequest);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            var request = new DeleteProductCommand(id);
            var result = await _mediator.Send(request);
            if (result == null)
                return NotFound();
            else
                return Ok("Item Deleted");
        }
    }
}
