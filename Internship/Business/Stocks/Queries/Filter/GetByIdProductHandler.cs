using AutoMapper;
using Internship.Controllers.Stocks.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Stocks.Queries.Filter
{
    public class GetByIdProductHandler : IRequestHandler<GetByIdProductQuery, GetStockIdResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetByIdProductHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetStockIdResult> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            var items = _dbContext.Stocks.Include(x => x.Product).Where(x => x.ProductId == request.ProductId).FirstOrDefault();
            var itemsCopy = _mapper.Map<GetStockIdResult>(items);
            return itemsCopy;

        }
    }
}
