using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Controllers.Products.Pagination
{
    public class ProductPaginationHandler : IRequestHandler<ProductGetByPageQuery, ProductPaginationResponse>
    {
        public readonly EcomDbContext _dbContext;
        public ProductPaginationHandler(EcomDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductPaginationResponse> Handle(ProductGetByPageQuery request, CancellationToken cancellationToken)
        {
            if (_dbContext.Products == null)
                return null;
            var pageResult = request.ProductsOnPage;
            var pageCount=Math.Ceiling(_dbContext.Products.Count()/pageResult);

            var products = await _dbContext.Products
                .Skip((request.Page-1)*(int)pageResult)
                .Take((int)pageResult)
                .ToListAsync();
            var response = new ProductPaginationResponse
            {
                Products = products,
                CurrentPage = request.Page,
                Pages = (int)pageCount
            };
            return response;
        }
    }
}
