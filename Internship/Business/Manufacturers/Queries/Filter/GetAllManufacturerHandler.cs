using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Manufacturers.Queries.Filter
{
    public class GetAllManufacturerHandler : IRequestHandler<GetAllManufacturerQuery, List<Manufacturer>>
    {
        private readonly EcomDbContext _dbContext;
        public GetAllManufacturerHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Manufacturer>> Handle(GetAllManufacturerQuery request, CancellationToken cancellationToken)
        {
            var items = await _dbContext.Manufacturers.ToListAsync();
            return items;
        }
    }
}