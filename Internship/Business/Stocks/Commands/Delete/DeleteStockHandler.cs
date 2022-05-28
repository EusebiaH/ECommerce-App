using AutoMapper;
using Internship.Business.Stocks.Commands.Create;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Stocks.Commands.Delete
{
    public class DeleteStockHandler : IRequestHandler<DeleteStockCommand, Stock>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public DeleteStockHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<Stock> Handle(DeleteStockCommand request, CancellationToken cancellationToken)
        {
            var stock = await _dbContext.Stocks.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (stock != null)
            {
                _dbContext.Stocks.Remove(stock);
                await _dbContext.SaveChangesAsync();
            }
            return stock;
        }
    }
}
