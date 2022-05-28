using MediatR;
using Internship.Data;
using AutoMapper;
using Internship.Controllers.Stocks.ModelsStock;

namespace Internship.Business.Stocks.Commands.Create
{
    public class CreateStockHandler: IRequestHandler<CreateStockCommand, StockResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateStockHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<StockResult> Handle(CreateStockCommand request, CancellationToken cancellationToken)
        {
            var stock = _mapper.Map<Stock>(request);
            _dbContext.Stocks.Add(stock);
            await _dbContext.SaveChangesAsync();
            var newStock= _mapper.Map<StockResult>(stock);
            return newStock;
        }

    }
}
