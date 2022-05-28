using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Internship.Controllers.Counties
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly EcomDbContext _dbContext;

        public CountyController(IMediator mediator, IMapper mapper, EcomDbContext dbContext)
        {
            _mapper = mapper;
            _mediator = mediator;
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task <IActionResult> GetAllCounties()
        {
            var countyList = await _dbContext.Counties.ToListAsync();
            return Ok(countyList);
        }
    }
}
