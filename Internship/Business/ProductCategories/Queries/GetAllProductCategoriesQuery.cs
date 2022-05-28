using Internship.Data;
using MediatR;

namespace Internship.Business.ProductCategories.Queries
{
    public class GetAllProductCategoriesQuery : IRequest<List<ProductCategory>>
    {
    }
}
