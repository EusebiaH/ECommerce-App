using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Internship.Controllers.Countries
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly EcomDbContext _dbContext;

        public CountryController(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _mediator = mediator;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task <IActionResult> GetAllCountries()
        {
           var countryList = await _dbContext.Countries.ToListAsync();
            return Ok(countryList);
        }
    }
}
