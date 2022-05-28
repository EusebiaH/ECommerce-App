using AutoMapper;
using Internship.Business.Addresses.Commands.Create;
using Internship.Business.Addresses.Commands.Delete;
using Internship.Business.Addresses.Commands.Update;
using Internship.Business.Addresses.Queries;
using Internship.Business.Orders.Commands.Update;
using Internship.Controllers.Addresses.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Addresses
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator; 


        public AddressController(IMapper mapper , IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }



        // GET: api/<AddressController>
        [HttpGet]
        public async Task<IActionResult> GetAllAddresses()
        {
            var address = new GetAllAddressesQuery();
            var addresses = _mediator.Send(address).Result; 
            if(addresses == null)
                return NotFound();
            else
                return Ok(addresses);   
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var address = new GetAllAddressesByIdQuery(id);
            var address1 = _mediator.Send(address).Result;
            if (address1 == null)
                return NotFound();
            else
                return Ok(address1);
        }

        // POST api/<AddressController>
        [HttpPost]
        public IActionResult Post(PostAddressRequest address)
        {
            var addressRequest = _mapper.Map<PostAddressCommand>(address);
            var addressResult = _mediator.Send(addressRequest).Result;
            return Ok(addressResult);

        }



        // PUT api/<AddressController>/5
        [HttpPut]
        public IActionResult UpdateById(UpdateAddressRequest address)
        {

            var addressRequest = _mapper.Map<UpdateAddressCommand>(address);
            var addressResult = _mediator.Send(addressRequest).Result;
            if (addressResult == null)
                return NotFound();
            else
                return Ok(addressResult);
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var address = new DeleteAddressCommand(id);
            var addressResult = _mediator.Send(address).Result;
            if (addressResult == null)
                return NotFound();
            else
                return Ok("Address Deleted");
        }
    }
}
