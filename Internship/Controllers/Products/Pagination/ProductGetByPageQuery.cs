using Internship.Data;
using MediatR;

namespace Internship.Controllers.Products.Pagination
{
    public class ProductGetByPageQuery:IRequest<ProductPaginationResponse>
    {
        public int Page { get; set; }
        public double ProductsOnPage { get; set; }
        public ProductGetByPageQuery(int page,double objectsOnPage)
        {
            Page = page;
            ProductsOnPage = objectsOnPage;
        }
    }
}
