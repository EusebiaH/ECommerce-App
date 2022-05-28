using AutoMapper;
using Internship.Controllers.Stocks.Models;
using Internship.Controllers.Stocks.ModelsStock;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace Internship.Business.Stocks.Queries.GetById
{
    public class GetStockByIdHandler: IRequestHandler<GetStockByIdQuery, GetStockIdResult>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetStockByIdHandler(EcomDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<GetStockIdResult> Handle(GetStockByIdQuery request, CancellationToken cancellationToken)
        {
            var items =  _dbContext.Stocks.Where(x => x.Id == request.Id ).Include(x => x.Product).FirstOrDefault();
            var itemsCopy = _mapper.Map<GetStockIdResult>(items);
            return itemsCopy;
        }
    }
}
