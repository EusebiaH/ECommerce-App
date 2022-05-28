using Internship.Data.ProductCategorys;
using MediatR;

namespace Internship.Business.ProductCategories.Queries
{
    public class GetProductCategoryFilterQuery : IRequest<GetProductCategoryIdResult>
    {
        public int Id { get; set; }
        public GetProductCategoryFilterQuery(int id)
        {
            Id = id;
        }
    }
}
