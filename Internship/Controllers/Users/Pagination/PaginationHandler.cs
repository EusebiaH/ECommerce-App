using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Controllers.Users.Pagination
{
    public class PaginationHandler : IRequestHandler<GetByPageQuery, Response>
    {
        private readonly EcomDbContext _dbContext;

        public PaginationHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Response> Handle(GetByPageQuery request, CancellationToken cancellationToken)
        {
            if (_dbContext.Users == null)
                return null;

            var pageResults = request.ObjectsOnPage;
            var pageCount=Math.Ceiling(_dbContext.Users.Count()/pageResults);

            var users = await _dbContext.Users
                .Skip((request.Page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();

            var response = new Response
            {
                Users = users,
                CurrentPage = request.Page,
                Pages = (int)pageCount
            };
            return response;
        }
    }
}
