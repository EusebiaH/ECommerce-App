using AutoMapper;
using Internship.Controllers.Products.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.Products.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetProductsResult>>
    {
        private readonly EcomDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(EcomDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<List<GetProductsResult>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products =await _dbContext.Products.ToListAsync();
                return _mapper.Map<List<GetProductsResult>>(products);
        }
    }
}
