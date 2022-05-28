using AutoMapper;
using Internship.Business.Users.Commands.Create;
using Internship.Business.Users.Commands.Delete;
using Internship.Business.Users.Commands.Update;
using Internship.Business.Users.Queries.Filter;
using Internship.Business.Users.Queries.GetById;
using Internship.Controllers.Users.Models;
using Internship.Controllers.Users.Pagination;
using Internship.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Internship.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private EcomDbContext _dbContext;   // aducem informatii despre persoana
        private readonly IMapper _mapper;
        private readonly IMediator _mediatR;
        public UserController(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediatR = mediator;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _mediatR.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpGet("{page}")]
        public async Task<IActionResult> GetUsersPage(int page, double objectOnPage)
        {
            var item = new GetByPageQuery(page, objectOnPage);
            var user = _mediatR.Send(item);
            if(user.Result==null)
                return NotFound();
            else
                return Ok(user.Result);
        }








        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _mediatR.Send(new GetUserByIdQuery(id));
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<string> Post([FromBody] CreateUserRequest CreateUser)
        {
            var CreateUserQuery = _mapper.Map<CreateUserCommand>(CreateUser);
            var result = await _mediatR.Send(CreateUserQuery);
            return result;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] UpdateUserResult UserToUpdate)
        {
            var result = await _mediatR.Send(new UpdateUserCommand(id, UserToUpdate));
            return result;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            var result = await _mediatR.Send(new DeleteUserCommand(id));
            return result;
        }
    }
}
