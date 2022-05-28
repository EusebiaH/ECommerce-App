using Internship.Controllers.ProductCategoryXAttributes.Models;
using Internship.Data;
using MediatR;

namespace Internship.Business.ProductCategoryXAttributes.Queries.Filter
{
    public class GetAllProductCategoryXAttributeQuery : IRequest<List<GetAllProductCategoryXAttributeResult>>
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int AttributeId { get; set; }
    }
}
