using AutoMapper;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Controllers.Stocks.Pagination
{
    public class PaginationHandler: IRequestHandler<GetByPageQuery, List<StockPaginationResponse>>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public PaginationHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<StockPaginationResponse>> Handle(GetByPageQuery request, CancellationToken cancellationToken)
        {
            if (_dbContext.Stocks == null)
                return null;
            var pageResults = request.ObjectsOnPage; //3 stocuri pe pagina
            var pageCount = Math.Ceiling(_dbContext.Stocks.Count() / pageResults);



            var stocks = await _dbContext.Stocks
                .Skip((request.Page - 1) * (int)pageResults)
                .Take((int)pageResults).Include(x=>x.Product)
                .ToListAsync();


        
            return _mapper.Map<List<StockPaginationResponse>>(stocks);
        }
    }
}
