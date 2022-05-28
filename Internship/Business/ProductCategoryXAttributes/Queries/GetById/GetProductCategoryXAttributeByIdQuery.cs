using Internship.Controllers.ProductCategoryXAttributes.Models;
using MediatR;

namespace Internship.Business.ProductCategoryXAttributes.Queries.GetById
{
    public class GetProductCategoryXAttributeByIdQuery : IRequest<GetProductCategoryXAttributeById>
    {
        public int Id { get; set; }
        public GetProductCategoryXAttributeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
