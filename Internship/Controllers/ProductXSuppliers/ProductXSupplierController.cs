using AutoMapper;
using Internship.Business.ProductXSuppliers.Commands.Create;
using Internship.Business.ProductXSuppliers.Commands.Delete;
using Internship.Business.ProductXSuppliers.Commands.Update;
using Internship.Business.ProductXSuppliers.Queries.GetAll;
using Internship.Business.ProductXSuppliers.Queries.GetBySupplieId;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Controllers.ProductXSuppliers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductXSupplierController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private EcomDbContext _dbContext;

        public ProductXSupplierController(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var psListResult = await _mediator.Send(new GetAllPsQuery());
            return Ok(psListResult);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBySupplierId(int id)
        {
            var supplier = new GetBySupplierIdQuery(id);
            var psListResult = await _mediator.Send(supplier);
            return Ok(psListResult);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostPsRequest psRequest)
        {
            var ps = _mapper.Map<PostPsCommand>(psRequest);
            var psResult = await _mediator.Send(ps);
            return Ok(psResult);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatePsRequest psRequest)
        {
            var ps = _mapper.Map<UpdatePsCommand>(psRequest);
            var psResult = await _mediator.Send(ps);
            return Ok(psResult);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeletePsRequest psRequest)
        {
            var ps = _mapper.Map<DeletePsCommand>(psRequest);
            var psResult = await _mediator.Send(ps);
            return Ok(psResult);
        }
    }
}
