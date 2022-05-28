using Internship.Business.ProductCategories.Queries;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductCategories.Commands.Create
{
    public class GetAllProductCategoriesHandler : IRequestHandler<GetAllProductCategoriesQuery, List<ProductCategory>>
    {
        private readonly EcomDbContext _dbContext;
        public GetAllProductCategoriesHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ProductCategory>> Handle(GetAllProductCategoriesQuery request, CancellationToken cancellationToken)
        {
            var prod = await _dbContext.ProductCategorys.ToListAsync();
            return prod;
        }
    }
}
