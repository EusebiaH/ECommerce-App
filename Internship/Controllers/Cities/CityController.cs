using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Internship.Controllers.Cities
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly EcomDbContext _dbContext;

        public CityController(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _mediator = mediator;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCities()
        {
            var cityList = await _dbContext.Cities.ToListAsync();
            return Ok(cityList);
        }

    }
}
