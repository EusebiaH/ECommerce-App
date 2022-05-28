using AutoMapper;
using Internship.Business.Vats.Commands.Create;
using Internship.Business.Vats.Commands.Update;
using Internship.Business.Vats.Queries.GetById;
using Internship.Data;
using Internship.Data.Vats;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers.Vats
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VatController : ControllerBase
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public VatController(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        // GET: api/<VatController>
        [HttpGet]
        public async Task<IActionResult> GetAllVats()
        {
            var getVats = _dbContext.Vats;
            var getVatsResult = _mapper.Map<List<GetVatResult>>(getVats);
            return Ok(getVatsResult);
        }

        // GET api/<VatController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVatById(int id)
        {
             var x= new GetVatByIdQuery(id);
             return Ok(_mediator.Send(x).Result);
        }

        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateVatCommand request)
        {
            var med = _mediator.Send(request).Result;
            _dbContext.SaveChanges();
            return Ok(med);
        }

        // PUT api/<VatController>/5
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] UpdateVatCommand request)
        {
            var x = _mediator.Send(request).Result;
            return Ok(x);
        }

        // DELETE api/<VatController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
           var vat= _dbContext.Vats.FirstOrDefault(x=>x.Id==id);
            if (vat == null)
                return NotFound();
            _dbContext.Remove(vat);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
