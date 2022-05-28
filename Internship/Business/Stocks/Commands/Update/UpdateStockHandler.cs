using MediatR;
using Internship.Data;
using AutoMapper;
using Internship.Controllers.Stocks.ModelsStock;

namespace Internship.Business.Stocks.Commands.Update
{
    public class UpdateStockHandler : IRequestHandler<UpdateStockCommand, StockResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateStockHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<StockResult> Handle(UpdateStockCommand request, CancellationToken cancellationToken)
        {
            var stock = _dbContext.Stocks.FirstOrDefault(x => x.Id == request.Id);
            if (stock == null)
            {
                return null;
            }
            stock.ProductId = request.ProductId;
            stock.Quantity = request.Quantity;
            stock.PurchasePrice = request.PurchasePrice;
            stock.InvoiceDate = request.InvoiceDate;

            await _dbContext.SaveChangesAsync();
            return _mapper.Map<StockResult>(stock);
           
        }

    }
}
