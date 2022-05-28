using AutoMapper;
using Internship.Controllers.Users.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Users.Queries.GetById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, GetUserResult>
    {
        private readonly EcomDbContext _DbContext;
        private readonly IMapper _mapper;

        public GetUserByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _DbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetUserResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var User = _DbContext.Users.Include(p => p.UserType).FirstOrDefault(x => x.Id == request.Id);
            if (User == null)
            {
                return null;
            }
            else
            {
                var getUserResult = _mapper.Map<GetUserResult>(User);
                return getUserResult;
            }
        }
    }
}
