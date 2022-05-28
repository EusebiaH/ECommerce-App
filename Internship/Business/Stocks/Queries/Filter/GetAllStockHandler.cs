using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Stocks.Queries.Filter
{
    public class GetAllStockHandler : IRequestHandler<GetAllStockQuery, List<Stock>>
    {
        private readonly EcomDbContext _dbContext;
        public GetAllStockHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Stock>> Handle(GetAllStockQuery request, CancellationToken cancellationToken)
        {
            var items = await _dbContext.Stocks.Include(x => x.Product).ToListAsync();
            return items;
        }
    }
}
