using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.PhysicalPersons.Queries.Filter
{
    
    public class GetAllPhysicalPersonHandler : IRequestHandler<GetAllPhysicalPersonQuery, List<PhysicalPerson>>
    {
        private readonly EcomDbContext _dbContext;
        public GetAllPhysicalPersonHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<PhysicalPerson>> Handle(GetAllPhysicalPersonQuery request, CancellationToken cancellationToken)
        {
            var items = await _dbContext.PhysicalPersons.Include(x => x.User).ToListAsync();
            return items;
        }
    }
}
