using AutoMapper;
using Internship.Business.Suppliers.Commands.Create;
using Internship.Business.Suppliers.Commands.Delete;
using Internship.Business.Suppliers.Commands.Update;
using Internship.Business.Suppliers.Queries.GetAll;
using Internship.Controllers.Suppliers.Models;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Internship.Controllers.Suppliers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        

        public SupplierController( IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("{page}")]
        public async Task<IActionResult> GetAllSuppliers(int page, int objectsOnPage)
        {
            var supplier = new GetAllSuppliersQuery(page, objectsOnPage);
            var mySupplier = await _mediator.Send(supplier);

            if(mySupplier == null)
                return NotFound();
            else
                return Ok(mySupplier);
        }

        //public IActionResult GetByName(string name)
       

        [HttpPost]
        public async Task<IActionResult> Post(PostSupplierRequest request)
        {
            var supplier = _mapper.Map<PostSupplierCommand>(request);
            var supplierResult = await _mediator.Send(supplier);
            return Ok(supplierResult);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteSupplierRequest request)
        {
            var supplier = _mapper.Map<DeleteSupplierCommand>(request.Name);
            var deleteSupplier = await _mediator.Send(supplier);
            return Ok(deleteSupplier);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSupplierRequest request)
        {
            var supplier = _mapper.Map<UpdateSupplierCommand>(request);
            var updatedSupplier = await _mediator.Send(supplier);
            return Ok(updatedSupplier);
        }
    }
}
