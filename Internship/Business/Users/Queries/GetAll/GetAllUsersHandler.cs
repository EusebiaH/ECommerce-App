using AutoMapper;
using Internship.Controllers.Users.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Users.Queries.Filter
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<GetUserResult>>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public GetAllUsersHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<GetUserResult>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var results = await _DbContext.Users.Include(p => p.UserType).ToListAsync();
            var getUserResults = _mapper.Map<List<GetUserResult>>(results);
            return getUserResults;
        }
    }
}
